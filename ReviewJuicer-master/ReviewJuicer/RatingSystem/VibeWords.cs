using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJuicer.RatingSystem
{
    public class VibeWords
    {
        public List<string> SuperPuper { get; set; }
        public int superPuperScore;
        public List<string> Good { get; set; }
        public int goodScore;
        public List<string> Neutral { get; set; }
        public int neutralScore;
        public List<string> Bad { get; set; }
        public int badScore;
        public List<string> Shit { get; set; }
        public int shitScore;
        // 2 * 3 + 1 * 4 / 3
        public VibeWords()
        {
            SuperPuper = new List<string> { "best", "finest", "outstanding", "terrific",
                "perfect", "ideal", "superb", "splendid", "impeccable", "flawless", "awesome",
                "amazing", "super", "awesome", "fascinating", "incredible", "marvelous",
                "staggering", 
                "startling", "prodigious", "shocking", "stunning", "surprising", "unbelievable", "excellent" };

            superPuperScore = 10;

            Good = new List<string> { "acceptable", "good", "wonderful", "admirable",
                "astonishing", "fine", "cool", "enjoyable", "fabulous", "magnificent", "marvelous", 
                "pleasant", "pleasing", "wondrous", "remarkable", "tremendous", "pleasing",
                "delightful", 
                "stupendous", "honorable", "honourable", "nice", "great", "positive", "satisfactory", "satisfying" };

            goodScore = 7;

            Neutral = new List<string> { "cool", "neutral", "good", "impartial", "indifferent", "inactive",
                "sufficient", "modest", "satisfactory", "satisfying", 
                "tolerable", "common", "fair", "decent", "average", "admissible" };

            neutralScore = 5;

            Bad = new List<string> { "bad", "blah", "downer", "faulty", "unsatisfactory", "unsatisfying", 
                "ugly", "unpleasant", "horrible", "dire", "distressing", "horrendous", "horrid", 
                "nasty", "terrible", "lousy", "hideous", "unwanted", "unappealing", 
                "obnoxious", "questionable", "repulsive", "repellent", "silly", 
                "incorrect", "sad", "unacceptable", "poor", "crummy", "cheap", "imperfect" };

            badScore = 2;

            Shit = new List<string> { "atrocious", "awful", "dreadful", "crap", "crappy",
                "depressing", "gruesome", "nasty", "abhorent", "disgusting", "abhorent", 
                "abhorent", "appaling", "shameful", "terrible", "idiot", "idiotic", "foolish", 
                "shit", "gross" };

            shitScore = 0;
        }
    }
}
