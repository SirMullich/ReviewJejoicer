using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJuicer.RatingSystem
{
    public class DescriptionWord : IComparable<DescriptionWord>
    {
        public string Word { get; set; }
        public int Count { get; set; }

        public DescriptionWord()
        {
            Word = "";
            Count = 0;
        }

        public DescriptionWord(string w, int c)
        {
            Word = w;
            Count = c;
        }

        public int CompareTo(DescriptionWord other)
        {
            return this.Count.CompareTo(other.Count);
        }
    }
}
