using DesignPatternsStructural.Bridge.Abstractions;
using DesignPatternsStructural.Bridge.Interface;
using System.Text;

namespace DesignPatternsStructural.Bridge.Reports.InventoryReport
{
    public class InventoryReport : ReportModel
    {
        private readonly Dictionary<string, int> _stock;

        public InventoryReport(IReportExport reportExport, Dictionary<string, int> stock) : base(reportExport)
        {
            _stock = stock;
        }

        public override string GetContent()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Relatório de Estoque");

            foreach (var item in _stock)
                sb.AppendLine($"Item: {item.Key} | Quantidade em estoque: {item.Value}");
            
            return sb.ToString();
        }
    }
}
