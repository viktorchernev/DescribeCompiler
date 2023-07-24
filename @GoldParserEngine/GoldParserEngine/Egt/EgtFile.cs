using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.Egt
{
    public class EgtFile
    {
        public string Header { get; set; }
        public List<EgtRecord> Records { get; set; }

        public EgtFile(List<EgtRecord> records, string header)
        {
            Records = records;
            Header = header;
        }
    }
}
