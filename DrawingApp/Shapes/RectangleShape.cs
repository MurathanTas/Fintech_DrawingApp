using DrawingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Shapes
{
    public class RectangleShape : Shape, ISerializableShape
    {
        public RectangleShape(Point start, Color color) : base(start, color) { }

        public override void Draw(Graphics g)
        {
            var rect = GetNormalizedRectangle();
            using var br = new SolidBrush(FillColor);
            g.FillRectangle(br, rect);
            g.DrawRectangle(Pens.Black, rect);
        }

        public override bool Contains(Point p) =>
            GetNormalizedRectangle().Contains(p);

        private Rectangle GetNormalizedRectangle()
        {
            return new Rectangle(
                Math.Min(Start.X, End.X),
                Math.Min(Start.Y, End.Y),
                Math.Abs(End.X - Start.X),
                Math.Abs(End.Y - Start.Y));
        }

        public override Rectangle GetBounds()
        {
            return GetNormalizedRectangle();
        }

        public string Serialize()
        {
            return $"Rectangle;{Start.X};{Start.Y};{End.X};{End.Y};{FillColor.ToArgb()}";
        }

    
    }

}
