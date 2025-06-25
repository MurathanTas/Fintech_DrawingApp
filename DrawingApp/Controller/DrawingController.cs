using DrawingApp.Services;
using DrawingApp.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Controller
{
    public class DrawingController
    {
        private readonly Panel _canvas;
        private readonly ShapeManager _shapeManager = new();
        private readonly IDrawingRepository _repo;

        private Tool _currentTool = Tool.None;
        private Shape? _currentDraft;
        private Color _activeColor = Color.Black;
        private Shape? _selectedShape;
        private Point _lastMouse;

        private const int HighlightPadding = 6;
        private readonly Color HighlightColor = Color.FromArgb(80, Color.DarkGreen);

        public event EventHandler? SelectionChanged;

        public DrawingController(Panel canvas, IDrawingRepository? repo = null)
        {
            _canvas = canvas;
            _repo = repo ?? new TxtDrawingRepository();

            _canvas.MouseDown += Canvas_MouseDown;
            _canvas.MouseMove += Canvas_MouseMove;
            _canvas.MouseUp += Canvas_MouseUp;
            _canvas.Paint += Canvas_Paint;

            typeof(Panel)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance |
                                              System.Reflection.BindingFlags.NonPublic)!
                .SetValue(_canvas, true, null);
        }

        public void SetTool(Tool tool) => _currentTool = tool;

        public void SetColor(Color color)
        {
            _activeColor = color;
            if (_currentTool == Tool.Cursor && _selectedShape != null)
            {
                _selectedShape.ChangeColor(color);
                _canvas.Invalidate();
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void DeleteSelectedShape()
        {
            if (_currentTool != Tool.Cursor || _selectedShape == null) return;
            _shapeManager.Remove(_selectedShape);
            _selectedShape = null;
            _canvas.Invalidate();
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        public void RefreshCanvas()
        {
            _shapeManager.Clear();
            _currentDraft = null;
            _selectedShape = null;
            _canvas.Invalidate();
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Save(string path) =>
            _repo.Save(path, _shapeManager.Shapes, _shapeManager.IndexOf(_selectedShape));

        public void Load(string path)
        {
            var (list, selIdx) = _repo.Load(path);
            _shapeManager.Clear();
            foreach (var s in list) _shapeManager.Add(s);

            _selectedShape = _shapeManager.GetAt(selIdx);
            _currentDraft = null;
            _activeColor = _selectedShape?.FillColor ?? _activeColor; 

            _canvas.Invalidate();
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        public Color ActiveColor => _activeColor;
        public Shape? SelectedShape => _selectedShape;

        private void Canvas_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            if (_currentTool == Tool.Cursor)
            {
                _selectedShape = _shapeManager.HitTest(e.Location);
                _activeColor = _selectedShape?.FillColor ?? _activeColor; 
                _lastMouse = e.Location;
                _canvas.Invalidate();
                SelectionChanged?.Invoke(this, EventArgs.Empty);
                return;
            }

            _currentDraft = _currentTool switch
            {
                Tool.Rectangle => new RectangleShape(e.Location, _activeColor),
                Tool.Ellipse => new Ellipse(e.Location, _activeColor),
                Tool.Triangle => new Triangle(e.Location, _activeColor),
                Tool.Hexagon => new Hexagon(e.Location, _activeColor),
                _ => null
            };
        }

        private void Canvas_MouseMove(object? sender, MouseEventArgs e)
        {
            if (_currentTool == Tool.Cursor &&
                _selectedShape != null &&
                e.Button == MouseButtons.Left)
            {
                int dx = e.X - _lastMouse.X;
                int dy = e.Y - _lastMouse.Y;

                _selectedShape.Translate(dx, dy);
                Rectangle b = _selectedShape.GetBounds();
                bool reject = !_canvas.ClientRectangle.Contains(b) ||
                              _shapeManager.IntersectsAny(_selectedShape, _selectedShape);

                if (reject)
                {
                    _selectedShape.Translate(-dx, -dy);
                    SystemSounds.Beep.Play();
                }
                else
                {
                    _lastMouse = e.Location;
                }
                _canvas.Invalidate();
                return;
            }

            if (_currentDraft is null || e.Button != MouseButtons.Left) return;
            _currentDraft.UpdateEnd(ClampPointToCanvas(e.Location));
            _canvas.Invalidate();
        }

        private void Canvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (_currentTool == Tool.Cursor) return;
            if (_currentDraft is null) return;

            bool accept = _canvas.ClientRectangle.Contains(_currentDraft.GetBounds()) &&
                          !_shapeManager.IntersectsAny(_currentDraft);
            if (accept) _shapeManager.Add(_currentDraft); else SystemSounds.Beep.Play();

            _currentDraft = null;
            _canvas.Invalidate();
        }

        private void Canvas_Paint(object? sender, PaintEventArgs e)
        {
            if (_selectedShape != null)
            {
                Rectangle r = _selectedShape.GetBounds();
                r.Inflate(HighlightPadding, HighlightPadding);
                using var br = new SolidBrush(HighlightColor);
                e.Graphics.FillRectangle(br, r);
            }
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _shapeManager.DrawAll(e.Graphics);
            _currentDraft?.Draw(e.Graphics);
        }

        private Point ClampPointToCanvas(Point p)
        {
            var r = _canvas.ClientRectangle;
            return new Point(
                Math.Max(r.Left, Math.Min(p.X, r.Right - 1)),
                Math.Max(r.Top, Math.Min(p.Y, r.Bottom - 1))
            );
        }
    }
}
