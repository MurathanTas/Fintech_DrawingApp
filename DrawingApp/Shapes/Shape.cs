using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Shapes
{
    public abstract class Shape
    {
        protected Point Start { get; private set; }
        protected Point End { get; private set; }

        public Color FillColor { get; private set; }

        protected Shape(Point start, Color color)
        {
            Start = start;
            End = start;
            FillColor = color;
        }

        public void UpdateEnd(Point p) => End = p;
        public virtual void Translate(int dx, int dy)
        {
            Start = new Point(Start.X + dx, Start.Y + dy);
            End = new Point(End.X + dx, End.Y + dy);
        }

        public void ChangeColor(Color c) => FillColor = c;

        public abstract Rectangle GetBounds();
        public abstract void Draw(Graphics g);
        public abstract bool Contains(Point p);
    }

}
