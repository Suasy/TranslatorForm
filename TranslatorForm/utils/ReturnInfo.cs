using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorForm
{
    [Serializable]
    public class ReturnInfo
    {
        public string from { get; set; }
        public string to { get; set; }
        public TransResult[] trans_result { get; set; }
    }

    [Serializable]
    public class TransResult
    {
        public string src { get; set; }
        public string dst { get; set; }
    }
}
