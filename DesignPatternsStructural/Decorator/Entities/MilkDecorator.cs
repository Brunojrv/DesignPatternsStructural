using DesignPatternsStructural.Decorator.Abstractions;
using DesignPatternsStructural.Decorator.Interface;

namespace DesignPatternsStructural.Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee baseCoffee) : base(baseCoffee) { }

        public override double GetCost()
        {
            return _baseCoffee.GetCost() + 0.50; 
        }

        public override string GetIngredients()
        {
            return _baseCoffee.GetIngredients() + ", Leite";
        }
    }
}
