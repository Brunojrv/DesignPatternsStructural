using DesignPatternsStructural.Decorator.Interface;

namespace DesignPatternsStructural.Decorator.Abstractions
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _baseCoffee;

        public CoffeeDecorator(ICoffee baseCoffee)
        {
            _baseCoffee = baseCoffee;
        }

        public abstract double GetCost();

        public abstract string GetIngredients();
    }
}
