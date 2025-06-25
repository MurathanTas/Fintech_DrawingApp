using DrawingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Shapes
{
    public class ShapeManager
    {
        private readonly List<Shape> _shapes = new();
        public int IndexOf(Shape? s) => _shapes.IndexOf(s!);
        public Shape? GetAt(int i) => (i >= 0 && i < _shapes.Count) ? _shapes[i] : null;

        public void Add(Shape shape) => _shapes.Add(shape);

        public void DrawAll(Graphics g)
        {
            foreach (var s in _shapes)
                s.Draw(g);          
        }

        public Shape? HitTest(Point p)
        {
            for (int i = _shapes.Count - 1; i >= 0; i--)
                if (_shapes[i].Contains(p))
                    return _shapes[i];
            return null;
        }

        public bool IntersectsAny(Shape shape, Shape? ignore = null)
        {
            Rectangle bounds = shape.GetBounds();
            Rectangle padded = bounds;
            padded.Inflate(2, 2);   
            return _shapes.Any(s => s != ignore && s.GetBounds().IntersectsWith(padded));
        }

        public void Remove(Shape s) => _shapes.Remove(s);
        public void Clear() => _shapes.Clear();

   
        public IReadOnlyList<Shape> Shapes => _shapes;   
    }

    public enum Tool
    {
        None,
        Rectangle,
        Ellipse,
        Triangle,
        Hexagon,
        Cursor

    }
}
