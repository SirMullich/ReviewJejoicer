using ReviewJuicer.RatingSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReviewJuicer
{
    public class Rating
    {
        public string title;
        public double val;
        public List<int> scores;
        public string text;
        public List<string> keywords;
        public VibeWords vibewords;
        public List<DescriptionWord> frequentlyUsed;

        public Rating()
        {
            scores = new List<int>();
            keywords = new List<string>();
            frequentlyUsed = new List<DescriptionWord>();
        }

        public bool CheckWord(string word)
        {
            if (vibewords.SuperPuper.Exists(a => a == word))
            {
                if (frequentlyUsed.Exists(a => a.Word == word))
                {
                    frequentlyUsed.First(a => a.Word == word).Count++;
                }
                else
                {
                    frequentlyUsed.Add(new DescriptionWord(word, 1));
                }
                scores.Add(vibewords.superPuperScore);
                return true;
            }
            if (vibewords.Good.Exists(a => a == word))
            {
                if (frequentlyUsed.Exists(a => a.Word == word))
                {
                    frequentlyUsed.First(a => a.Word == word).Count++;
                }
                else
                {
                    frequentlyUsed.Add(new DescriptionWord(word, 1));
                }
                scores.Add(vibewords.goodScore);
                return true;
            }
            if (vibewords.Neutral.Exists(a => a == word))
            {
                if (frequentlyUsed.Exists(a => a.Word == word))
                {
                    frequentlyUsed.First(a => a.Word == word).Count++;
                }
                else
                {
                    frequentlyUsed.Add(new DescriptionWord(word, 1));
                }
                scores.Add(vibewords.neutralScore);
                return true;
            }
            if (vibewords.Bad.Exists(a => a == word))
            {
                if (frequentlyUsed.Exists(a => a.Word == word))
                {
                    frequentlyUsed.First(a => a.Word == word).Count++;
                }
                else
                {
                    frequentlyUsed.Add(new DescriptionWord(word, 1));
                }
                scores.Add(vibewords.badScore);
                return true;
            }
            if (vibewords.Good.Exists(a => a == word))
            {
                if (frequentlyUsed.Exists(a => a.Word == word))
                {
                    frequentlyUsed.First(a => a.Word == word).Count++;
                }
                else
                {
                    frequentlyUsed.Add(new DescriptionWord(word, 1));
                }
                scores.Add(vibewords.shitScore);
                return true;
            }
            return false;
        }

        public void CalculateRatingValue()
        {
            val = 0;
            foreach (var score in scores)
            {
                val += (double)score;
            }
            val /= (double)scores.Count;  
        }

        public virtual void GenerateText()
        {
            frequentlyUsed.Sort();
            text = title + ": ";
            int j = 0;
            for (int i = 0; i < frequentlyUsed.Count && j < 3; i++)
            {
                text += frequentlyUsed[i].Word + ", ";
                j++;
            }
        }

        public void ProcessRating()
        {
            CalculateRatingValue();
            GenerateText();
            text = text.Substring(0, text.Length - 2);
            text += ".";
        }
    }

    public class ActorRating : Rating
    {
        public Person actor;
        public ActorRating()
        {
            title = "Actor play";
            val = 0;
            scores = new List<int>();
            text = "";
            keywords = new List<string>();
            vibewords = new VibeWords();
            frequentlyUsed = new List<DescriptionWord>();
        }

        public ActorRating(Person actor) : this()
        {
            this.actor = actor;
            keywords.AddRange(new string[] { actor.Name, actor.Surname, "actor", "actress" });
        }

        public override void GenerateText()
        {
            frequentlyUsed.Sort();
            text = actor.Name + " " + actor.Surname + " played: ";
            int j = 0;
            for (int i = 0; i < frequentlyUsed.Count && j < 3; i++)
            {
                text += frequentlyUsed[i].Word + ", ";
                j++;
            }
        }
    }

    public class DirectorRating : Rating
    {
        public Person director;

        public DirectorRating()
        {
            title = "Director work";
            val = 0;
            scores = new List<int>();
            text = "";
            keywords = new List<string>();
            vibewords = new VibeWords();
            frequentlyUsed = new List<DescriptionWord>();
        }

        public DirectorRating(Person dir) : this()
        {
            director = dir;
            keywords.AddRange(new string[] { director.Name, director.Surname, "director" });
        }

        public override void GenerateText()
        {
            frequentlyUsed.Sort();
            text = director.Name + " " + director.Surname + " directed: ";
            int j = 0;
            for (int i = 0; i < frequentlyUsed.Count && j < 3; i++)
            {
                text += frequentlyUsed[i].Word + ", ";
                j++;
            }
        }

    }

    public class PlotRating : Rating
    {
        public PlotRating()
        {
            title = "Plot";
            val = 0;
            scores = new List<int>();
            text = "";
            // temporary MOVIE and FILM are in this category
            keywords = new List<string> { "plot", "story", "content", "movie", "film", "picture" };
            vibewords = new VibeWords();
            frequentlyUsed = new List<DescriptionWord>();
        }
    }
}