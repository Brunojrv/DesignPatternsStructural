namespace DesignPatternsStructural.Facade.Service
{
    public class FiscoService
    {
        public void IssueInvoice(int orderId, decimal total)
        {
            Console.WriteLine($"[FiscoService] Emitindo nota fiscal para o pedido {orderId}, valor R${total}.");
        }
    }
}
