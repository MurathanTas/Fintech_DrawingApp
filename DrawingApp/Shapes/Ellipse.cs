using DrawingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Shapes
{
    public class Ellipse : Shape, ISerializableShape
    {
        public Ellipse(Point start, Color color) : base(start, color) { }

        public override void Draw(Graphics g)
        {
            var rect = GetNormalizedRectangle();
            using var br = new SolidBrush(FillColor);
            g.FillEllipse(br, rect);
            g.DrawEllipse(Pens.Black, rect);
        }

        public override bool Contains(Point p) =>
            GetNormalizedRectangle().Contains(p);

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
            return $"Ellipse;{Start.X};{Start.Y};{End.X};{End.Y};{FillColor.ToArgb()}";
        }
    }
}
