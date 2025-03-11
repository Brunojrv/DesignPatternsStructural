using DesignPatternsStructural.Bridge.Interface;

namespace DesignPatternsStructural.Bridge.Abstractions
{
    public abstract class ReportModel
    {
        protected IReportExport _reportExport;

        protected ReportModel(IReportExport reportExport)
        {
            _reportExport = reportExport;
        }
      
        public abstract string GetContent();

        public void Export(string filePath)
        {
            string content = GetContent();
            _reportExport.Export(content, filePath);
        }

    }
}
