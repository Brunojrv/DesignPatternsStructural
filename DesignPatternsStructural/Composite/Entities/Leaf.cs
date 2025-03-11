using DesignPatternsStructural.Composite.Interface;

namespace DesignPatternsStructural.Composite
{
    public class Leaf : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a leaf");
        }
    }
}
