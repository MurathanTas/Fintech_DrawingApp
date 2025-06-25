using DrawingApp.Shapes;

namespace DrawingApp.Services
{
    public interface IDrawingRepository
    {
        void Save(string path,
                  IEnumerable<Shape> shapes,
                  int selectedIndex);

        (IEnumerable<Shape> shapes, int selectedIndex) Load(string path);
    }
}
