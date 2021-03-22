using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMToCSV.Class
{
    public class CSVLine
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Login { get; set; }
        public string Pwd { get; set; }
        public string Note { get; set; }
        public const string Folder = "FromKPM";

    }
}
