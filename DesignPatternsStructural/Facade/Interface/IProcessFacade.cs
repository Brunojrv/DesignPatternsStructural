namespace DesignPatternsStructural.Facade.Interface
{
    public interface IProcessFacade
    {
        bool FinalizeOrder(int productId, int amount, decimal value, string paymentMethod);
    }
}
