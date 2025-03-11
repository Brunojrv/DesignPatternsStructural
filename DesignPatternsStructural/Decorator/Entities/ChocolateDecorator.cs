using DesignPatternsStructural.Decorator.Abstractions;
using DesignPatternsStructural.Decorator.Interface;

namespace DesignPatternsStructural.Decorator
{
    public class ChocolateDecorator : CoffeeDecorator
    {
        public ICoffee _baseCoffee;
        public ChocolateDecorator(ICoffee baseCoffee) : base(baseCoffee)
        {
            _baseCoffee = baseCoffee;
        }

        public override double GetCost()
        {
            return _baseCoffee.GetCost() + 0.100;
        }

        public override string GetIngredients()
        {
            return _baseCoffee.GetIngredients() + ", Chocolate";
        }
    }
}
