using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJuicer.RatingSystem
{
    public static class MotherLittleHelper
    {
        public static string RemovePunctuation(string str)
        {
            List<char> punctuation = new List<char> { '.', ',', '?', ':', ';', '@', '\'' };
            if (punctuation.Exists(a => a == str[str.Length - 1]))
            {
                return str.Remove(str.Length - 1);
            }
            else return str;
        }
    }
}
