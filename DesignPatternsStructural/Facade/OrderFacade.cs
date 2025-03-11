using DesignPatternsStructural.Facade.Interface;
using DesignPatternsStructural.Facade.Service;
using System.Drawing;

namespace DesignPatternsStructural.Facade
{
    public class OrderFacade : IProcessFacade
    {
        private readonly StockService _stockService;
        private readonly PaymentService paymentService;
        private readonly FiscoService _fiscoService;

        public OrderFacade(StockService stock, PaymentService payment, FiscoService fisco)
        {
            _stockService = stock;
            paymentService = payment;
            _fiscoService = fisco;
        }

      

        public bool FinalizeOrder(int productId, int amount, decimal value, string paymentMethod)
        {
            if (!_stockService.ValidStock(productId, amount))
                return false;
            

            if (!paymentService.ProcessPayment(value, paymentMethod))
                return false;
            
            _stockService.DownloadStock(productId, amount);
            _fiscoService.IssueInvoice(/*pedidoId*/ 123, value);

            return true;
        }
    }
}
