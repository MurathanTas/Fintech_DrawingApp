using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Shapes
{
    public static class ShapeFactory
    {
        public static Shape? FromString(string line)
        {
            var parts = line.Split(';');
            if (parts.Length != 6) return null;

            string type = parts[0];
            int sx = int.Parse(parts[1]),
                 sy = int.Parse(parts[2]),
                 ex = int.Parse(parts[3]),
                 ey = int.Parse(parts[4]);
            Color color = Color.FromArgb(int.Parse(parts[5]));

            Point endPt = new(ex, ey);

            return type switch
            {
                "Rectangle" => Create(new RectangleShape(new Point(sx, sy), color)),
                "Ellipse" => Create(new Ellipse(new Point(sx, sy), color)),
                "Triangle" => Create(new Triangle(new Point(sx, sy), color)),
                "Hexagon" => Create(new Hexagon(new Point(sx, sy), color)),
                _ => null
            };

            
            Shape Create(Shape s) { s.UpdateEnd(endPt); return s; }
        }
    }

}
