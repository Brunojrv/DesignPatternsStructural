namespace DesignPatternsStructural.Facade.Service
{
    public class StockService
    {
        public bool ValidStock(int produtoId, int quantidade)
        {
            if (produtoId == 10 && quantidade <= 5)
                return true;
            
            return false;
        }

        public void DownloadStock(int produtoId, int quantidade)
        {
            Console.WriteLine($"[StockService] Baixando {quantidade} do produto {produtoId}");
        }
    }
}
