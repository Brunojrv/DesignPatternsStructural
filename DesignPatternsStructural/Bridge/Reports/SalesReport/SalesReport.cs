using DesignPatternsStructural.Bridge.Abstractions;
using DesignPatternsStructural.Bridge.Interface;
using System.Text;

namespace DesignPatternsStructural.Bridge.Reports.SalesReport
{
    public class SalesReport : ReportModel
    {
        private readonly List<(string product, int amount, decimal total)> _sales;

        public SalesReport(IReportExport reportExport, List<(string, int, decimal)> sales) : base(reportExport)
        {
            _sales = sales;
        }

        public override string GetContent()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Relatório de Vendas");

            foreach (var sales in _sales)
                sb.AppendLine($"Produto: {sales.product} | Quant.: {sales.amount} | Total: R${sales.total}");
            
            return sb.ToString();
        }
    }
}
