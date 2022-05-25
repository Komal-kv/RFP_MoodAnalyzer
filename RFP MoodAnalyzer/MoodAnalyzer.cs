using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_MoodAnalyzer
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMethod()
        {
            if (message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            return "happy";
        }
    }
}
