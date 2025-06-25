using DrawingApp.Controller;
using DrawingApp.Services;
using DrawingApp.Shapes;
using System.Drawing.Drawing2D;
using System.Media;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private readonly DrawingController _controller;
        private readonly Button[] _toolButtons;
        private readonly Button[] _colorButtons;

        private readonly SaveFileDialog _dlgSave = new();
        private readonly OpenFileDialog _dlgOpen = new();


        public Form1()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();

            _controller = new DrawingController(panelCanvas);
            _controller.SelectionChanged += (_, __) => UpdateUIFromSelection();

            _toolButtons = new[] { pick_rectangle, pick_ellipse, pick_triangle, pick_hexagon, pick_cursor };
            _colorButtons = new[] { pick_red, pick_blue, pick_green, pick_orange,
                                    pick_purple, pick_brown, pick_white,
                                    pick_yellow, pick_black };

            Configure(_toolButtons, 3, keepBackColor: false);
            Configure(_colorButtons, 3, keepBackColor: true);

            WireUiEvents();
        }

        private static void Configure(Button[] group, int border, bool keepBackColor = true)
        {
            foreach (var btn in group)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.UseVisualStyleBackColor = false;
                btn.FlatAppearance.BorderSize = border;
                btn.FlatAppearance.BorderColor = SystemColors.Control;
                if (!keepBackColor) btn.BackColor = SystemColors.Control;
            }
        }

        private void WireUiEvents()
        {
            // Şekil butonları
            pick_rectangle.Click += (s, _) => SelectTool(Tool.Rectangle, (Button)s!);
            pick_ellipse.Click += (s, _) => SelectTool(Tool.Ellipse, (Button)s!);
            pick_triangle.Click += (s, _) => SelectTool(Tool.Triangle, (Button)s!);
            pick_hexagon.Click += (s, _) => SelectTool(Tool.Hexagon, (Button)s!);
            pick_cursor.Click += (s, _) => SelectTool(Tool.Cursor, (Button)s!);

            // Renk butonları
            pick_red.Click += (s, _) => SelectColor((Button)s!);
            pick_blue.Click += (s, _) => SelectColor((Button)s!);
            pick_green.Click += (s, _) => SelectColor((Button)s!);
            pick_orange.Click += (s, _) => SelectColor((Button)s!);
            pick_purple.Click += (s, _) => SelectColor((Button)s!);
            pick_brown.Click += (s, _) => SelectColor((Button)s!);
            pick_white.Click += (s, _) => SelectColor((Button)s!);
            pick_yellow.Click += (s, _) => SelectColor((Button)s!);
            pick_black.Click += (s, _) => SelectColor((Button)s!);

            // Diğer butonlar
            pick_delete.Click += (_, __) => _controller.DeleteSelectedShape();
            pick_refresh.Click += (_, __) => _controller.RefreshCanvas();

            pick_save.Click += (_, __) =>
            {
                if (_dlgSave.ShowDialog() != DialogResult.OK) return;
                _controller.Save(_dlgSave.FileName);
            };

            pick_file.Click += (_, __) =>
            {
                if (_dlgOpen.ShowDialog() != DialogResult.OK) return;
                _controller.Load(_dlgOpen.FileName);
            };
        }

        private void SelectTool(Tool tool, Button clicked)
        {
            _controller.SetTool(tool);
            Highlight(_toolButtons, clicked);
        }

        private void SelectColor(Button clicked)
        {
            _controller.SetColor(clicked.BackColor);
            Highlight(_colorButtons, clicked);
            
        }

        private static void Highlight(Button[] group, Button clicked)
        {
            foreach (var b in group)
                b.FlatAppearance.BorderColor = SystemColors.Control;
            clicked.FlatAppearance.BorderColor = Color.Gray;
        }

        // Seçili şekil veya renk değişince UI senkronizasyonu sağlar.
        private void UpdateUIFromSelection()
        {
            foreach (var b in _toolButtons)
            {
                if (b == pick_cursor)
                    continue;                                        
                b.FlatAppearance.BorderColor = SystemColors.Control; 
            }

            if (_controller.SelectedShape != null)
            {
                Button? shapeBtn = null;

                if (_controller.SelectedShape is RectangleShape)
                    shapeBtn = pick_rectangle;
                else if (_controller.SelectedShape is Ellipse)
                    shapeBtn = pick_ellipse;
                else if (_controller.SelectedShape is Triangle)
                    shapeBtn = pick_triangle;
                else if (_controller.SelectedShape is Hexagon)
                    shapeBtn = pick_hexagon;

                if (shapeBtn != null)
                    shapeBtn.FlatAppearance.BorderColor = Color.Gray;  // aktif kenar
            }

            foreach (var b in _colorButtons)
                b.FlatAppearance.BorderColor = SystemColors.Control;

            if (_controller.SelectedShape != null)
            {
                var clrBtn = _colorButtons
                    .FirstOrDefault(b => b.BackColor == _controller.SelectedShape.FillColor);
                if (clrBtn != null)
                    clrBtn.FlatAppearance.BorderColor = Color.Gray;
            }
        }
    }

}
