using DesignPatternsStructural.Decorator.Interface;

namespace DesignPatternsStructural.Decorator
{
    public class CoffeExpress : ICoffee
    {
        public double GetCost() => 2.00;

        public string GetIngredients() => "Café Expresso";
    }
}
