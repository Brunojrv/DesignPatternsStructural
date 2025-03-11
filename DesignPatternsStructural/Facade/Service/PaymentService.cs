namespace DesignPatternsStructural.Facade.Service
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal value, string paymentMethod)
        {
            if (paymentMethod == "Cartão")
            {
                Console.WriteLine($"[PaymentService] Pagamento de R${value} aprovado no cartão!");
                return true;
            }

            Console.WriteLine($"[PaymentService] Pagamento de R${value} reprovado! Forma não aceita: {paymentMethod}");
            return false;
        }
    }
}
