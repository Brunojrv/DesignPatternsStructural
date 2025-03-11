using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStructural.Bridge.Interface
{
    public interface IReportExport
    {
        void Export(string reportContent, string filePath);
    }
}
