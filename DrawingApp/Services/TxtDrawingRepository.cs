using DrawingApp.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Services
{
    public class TxtDrawingRepository : IDrawingRepository
    {
        public void Save(string path,
                         IEnumerable<Shape> shapes,
                         int selectedIndex)
        {
            var lines = new List<string> { $"SELECTED;{selectedIndex}" };

            lines.AddRange(
                shapes.OfType<ISerializableShape>()
                      .Select(s => s.Serialize()));

            File.WriteAllLines(path, lines);
        }

        public (IEnumerable<Shape>, int) Load(string path)
        {
            var list = new List<Shape>();
            int selIndex = -1;

            foreach (var line in File.ReadAllLines(path))
            {
                if (line.StartsWith("SELECTED;"))
                {
                    selIndex = int.Parse(line[9..]);
                    continue;
                }

                var s = ShapeFactory.FromString(line);
                if (s != null) list.Add(s);
            }

            return (list, selIndex);
        }
    }
}
