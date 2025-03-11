using DesignPatternsStructural.Composite.Interface;

namespace DesignPatternsStructural.Composite
{
    public class Circle : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
