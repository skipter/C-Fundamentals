using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.MovieTime
{
    class MovieTime
    {
        static void Main()
        {
            string favoriteGender = Console.ReadLine();
            string favoriteDuration = Console.ReadLine();

            var movieList = new Dictionary<string, Dictionary<string, TimeSpan>>();

            string input = Console.ReadLine();

            while (input != "POPCORN!")
            {
                string[] inputArgs = input.Split('|');
                string movieName = inputArgs[0];
                string genre = inputArgs[1];
                string duration = inputArgs[2];

                TimeSpan time = TimeSpan.Parse(duration, CultureInfo.InvariantCulture);

                if (!movieList.ContainsKey(genre))
                {
                    movieList.Add(genre, new Dictionary<string, TimeSpan>());
                }

                if (!movieList[genre].ContainsKey(movieName))
                {
                    movieList[genre].Add(movieName, time);
                }

                input = Console.ReadLine();
            }

            if (favoriteDuration == "Short")
            {
                movieList[favoriteGender] = movieList[favoriteGender]
                    .OrderBy(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);
            }
            else
            {
                movieList[favoriteGender] = movieList[favoriteGender]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);
            }

            foreach (var item in movieList[favoriteGender])
            {
                //print the movie
                Console.WriteLine(item.Key);
                string wifeCommand = Console.ReadLine();

                if (wifeCommand == "Yes")
                {
                    var totalSeconds = movieList.Values.Sum(x => x.Sum(s => s.Value.TotalSeconds));

                    int hours = (int)totalSeconds / 60 / 60;
                    int minutes = (int)totalSeconds / 60 % 60;
                    int seconds = (int)totalSeconds % 60;

                    Console.WriteLine($"We're watching {item.Key} - {item.Value}");
                    Console.WriteLine($"Total Playlist Duration: {hours:D2}:{minutes:D2}:{seconds:D2}");
                    return;
                }
            }
        }
    }
}
