using DrawingApp.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Shapes
{
    public class Triangle : Shape, ISerializableShape
    {
        public Triangle(Point start, Color color) : base(start, color) { }

        public override void Draw(Graphics g)
        {
            var pts = GetPoints();
            using var br = new SolidBrush(FillColor);
            g.FillPolygon(br, pts);
            g.DrawPolygon(Pens.Black, pts);
        }

        public override bool Contains(Point p)
        {
            using var path = new GraphicsPath();
            path.AddPolygon(GetPoints());
            return path.IsVisible(p);
        }

        private Point[] GetPoints()
        {
            var rect = GetNormalizedRectangle();
            return new[]
            {
                new Point(rect.Left  + rect.Width / 2, rect.Top),         
                new Point(rect.Left,                    rect.Bottom),      
                new Point(rect.Right,                   rect.Bottom)       
            };
        }

        private Rectangle GetNormalizedRectangle() =>
            new(
                Math.Min(Start.X, End.X),
                Math.Min(Start.Y, End.Y),
                Math.Abs(End.X - Start.X),
                Math.Abs(End.Y - Start.Y));

        public override Rectangle GetBounds()
        {
           return GetNormalizedRectangle();
        }

        public string Serialize()
        {
            return $"Triangle;{Start.X};{Start.Y};{End.X};{End.Y};{FillColor.ToArgb()}";
        }
    }
}
