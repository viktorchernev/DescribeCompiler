using System.Collections.Generic;

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
