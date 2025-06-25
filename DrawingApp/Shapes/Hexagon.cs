using DrawingApp.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Shapes
{
    public sealed class Hexagon : Shape, ISerializableShape
    {
        public Hexagon(Point start, Color color) : base(start, color) { }

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
            int w = rect.Width, h = rect.Height;
            int dx = w / 4;            
            int dy = h / 2;            

            return new[]
            {
                new Point(rect.Left + dx, rect.Top),                 
                new Point(rect.Right - dx, rect.Top),                
                new Point(rect.Right,       rect.Top + dy),         
                new Point(rect.Right - dx, rect.Bottom),             
                new Point(rect.Left + dx,  rect.Bottom),             
                new Point(rect.Left,        rect.Top + dy)           
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
            return $"Hexagon;{Start.X};{Start.Y};{End.X};{End.Y};{FillColor.ToArgb()}";
        }
    }
}
