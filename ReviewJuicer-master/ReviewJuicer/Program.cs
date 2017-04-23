using ReviewJuicer.RatingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJuicer
{
    class Program
    {
        static void Main(string[] args)
        {

#region example
            ReviewJuicer rj = new ReviewJuicer(
                new List<string> { @"I know what the critics has said. They complained about too much action, superman being too serious, lack of romance, etc. Since Zack Snyder directed this movie, I don't think he cared about the critics. Don't get me wrong, he DOES care about the fans' opinion. Seems like he really wanted to really satisfy the fans. I see why critics complained about too much action. For me it's just his way to satisfy the viewers. This is the kind of movie that is just really satisfying. When the movie ended, I got that 'satisfying' feeling instead of the 'wanting more' feeling. It's like it was really enough. 

Even Snyder's best movies (before this) which were 300 & Watchmen didn't have more ratings than 64% on Rotten Tomatoes. I think the fans should have anticipated the bad reviews. His style is actually what critics hate. The over the top action and CGI is actually his trademark. So, even from the beginning, I think this is actually the kind of movie the producers wanted. About the lack of romance, I really do think it's saved for the sequel. The sequel will definitely explore more about the relationship between Clark and Lois. This film focused on 2 aspects: the origin (krypon,struggle finding his place) & the action (Zod and his army). Don't expect humor or romance.

The visuals were spectacular! What's best about this movie is its action scenes. The action were just relentless. I think the fans would not be disappointed at all. Yes, I know there is only a very few humor this movie but that actually doesn't even matter. The battle between Superman & Zod will definitely 'wow' everyone but the critics. I mean who cares about the critics opinion? A superhero movie MUST NOT be judged by the critics opinion, what's more important is the audience's opinion about the movie and especially the fans'. I think the movie really delivered. Most people will definitely like this movie. I am really sure that many fanboys will consider this as the best comic book of all time. This is a MUST SEE for people who like action movie. The action were better than last year's The Avengers. 

The sequel really have a great potential. Considering the minimum amount of romance in this movie (since they just knew each other, and superman was also more focused on Zod), the next movie could explore more of that. One of the things missing from the movie was also the presence of Clark Kent at the daily planet. It's one of the trade marks. But, I believe the sequel will show more scenes in the Daily Planet which is interesting to see. 

As a conclusion, I think Man of Steel is so far the best action movie this year. This movie really is a Snyder movie. But it also has a quite lot of nolan-esque feel to it especially in the around first 45 minutes.",

                @"The trailers of this movie were released in a so effective way that you start to fear if the product will fill your expectations. And with the usual critics-know-about-everything-nothing-is-good- to-me reviews the chances of be confused about this are increasing. As high as the expectations were raised after trailers, i have to tell you that you will not disappointed with this movie. Is different in many ways to the usual superhero movies but is a solid product that fits in what you expect from this kind of film. Nice references to previous movies are well executed and new plot additions are well received too. As you can expect from a Zack Snyder movie, there are several scenes that try to resemble graphic novel arts and in my opinion are very well made. Some of the nicest things about this movie is the way they made the fast moving scenes. The most of them (unfortunately i can't say all of them) look very realistic according laws of physics, the CGI are so well made that you wish that development for many movies you seen before. The movements are what you expect if such kind of people exist in reality. 

About the plot, i believe this is the more controversial point of what i see in reviews across the internet. Most moviegoers like it a lot, but are critics the ones ( not all of them) that are giving mixed reviews. What you realize is that critics expect another Dark Knight but this movie is not looking to be a darker one of your beloved Superman. If you are smart enough to understand that this is ANOTHER hero you will be happy with the story. If you are looking for a fourth darker than Batman movie for sure you will agree with critics giving bad reviews. This is a Superman movie and in that scenario this is a very good one.

The movie has some flaws to me for sure ( i don't know about a perfect movie) but i will not comment about that as i believe everyone need to discover by themselves what - if any- dislike for their preferences. 

In summary this is a super hero movie that even Marvel fans will appreciate as is giving a whole new level to a classic story, turning the most beloved hero in an actual hero and mixing a great graphic novel specialist with great digital artists to give you a full action packed movie that make a good foundations for sequels.",

                "I saw Man Of Steel last night at an advance screening and at no point was I looking down on the movie.From the trailers and TV spots the movie really gets you interested and dying for more.And the Movie itself soars(yes I know ha-ha)above the expectations. First of all Henry Cavill is an excellent Clark Kent/Superman. He really gives the character that \"not wanted\" or \"don't feel like you belong\" feeling.The cast in the movie is excellent including Russell Crowe and Michael Shannon. Russell Crowe really expands on Jor-el's character and makes him more than just a voice helping Clark.Michael Shannon as Zod is terrific.He was even better than Superman 2's Zod. The fight scenes in the movie are astonishing. It makes up for all the lack of conflict Superman Returns had.The fight scenes are very destructive yes but there is a very good story around it so it wasn't just mindless explosions like Transformers.Man of steel was by far the best movie of the year."},
                new List<Person> { new Person("Henry", "Cavill"), new Person("Amy", "Adams") },
                new Person("Zack", "Snyder")
                );
#endregion


            rj.ProcessReviews();
            foreach (var rating in rj.GetMovieRatings())
            {
                Console.WriteLine(rating.title);
                Console.WriteLine("rating = " + rating.CalculateRatingValue());
                rating.frequentlyUsed.Sort();
                foreach (var word in rating.frequentlyUsed)
                {
                    Console.WriteLine(word.Word + ": " + word.Count);
                }
            }
        }
    }
}
