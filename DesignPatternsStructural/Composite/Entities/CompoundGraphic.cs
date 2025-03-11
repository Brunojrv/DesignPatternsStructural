using DesignPatternsStructural.Composite.Interface;

namespace DesignPatternsStructural.Composite
{
    public class CompoundGraphic : IGraphic
    {
        private readonly List<IGraphic> _children = new List<IGraphic>();

        public void Add(IGraphic graphic)
        {
            _children.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            _children.Remove(graphic);
        }

        public void Draw()
        {
            Console.WriteLine("Desenhando um grupo de formas:");

            foreach (var child in _children)
                child.Draw(); 
        }
    }
}
