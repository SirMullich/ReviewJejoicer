using ReviewJuicer.RatingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJuicer
{
    public class ReviewJuicer
    {
        private List<string> textReviews;
        private List<Person> actors;
        private Person director;
        private List<Rating> movieRatings;
        private List<string> currentReview;

        public ReviewJuicer(List<string> textReviews, List<Person> actors, Person director)
        {
            this.textReviews = textReviews;
            this.actors = actors;
            this.director = director;
            currentReview = new List<string>();

            movieRatings = new List<Rating>();
            // 0 - plot
            movieRatings.Add(new PlotRating());
            // 1 - director
            movieRatings.Add(new DirectorRating(this.director));
            // 2 - others are actor ratings
            foreach (var act in this.actors)
            {
                movieRatings.Add(new ActorRating(act));
            }
        }

        public void ProcessReviews()
        {
            foreach (var review in textReviews)
            {
                currentReview = review.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                GiveRating();

                //foreach (var w in currentReview)
                //{
                //    Console.Write(w + " ");
                //}
            }
        }

        public void GiveRating()
        {
            for (int i = 0; i < currentReview.Count; i++)
            {
                foreach (var rating in movieRatings)
                {
                    string word = MotherLittleHelper.RemovePunctuation(currentReview[i].ToLower());
                    if (rating.keywords.Exists(a => a == word))
                    {
                        //Console.WriteLine(word);

                        // check 3 words away from keyword

                        for (int j = 0; j < 3; j++)
                        {
                            // before the keyword
                            if (i - j >= 0)
                            {
                                string beforeKeyword = MotherLittleHelper.RemovePunctuation(currentReview[i - j].ToLower());
                                rating.CheckWord(beforeKeyword);
                            }

                            // after the keyword
                            if (i + j < currentReview.Count)
                            {
                                string afterKeyword = MotherLittleHelper.RemovePunctuation(currentReview[i + j].ToLower());
                                rating.CheckWord(afterKeyword);
                            }
                        }
                    }
                }
            }
        }


        public List<Rating> GetMovieRatings()
        {
            return movieRatings;
        }
    }
}
