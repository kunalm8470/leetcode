using System;
using System.Linq;
using System.Collections.Generic;

namespace destination_city
{
    class Program
    {
        /// <summary>
        /// https://leetcode.com/problems/destination-city/
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string DestCity(IList<IList<string>> paths)
        {
            string destinationCity = paths[0][1];

            if (paths.Count == 1) return destinationCity;

            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < paths.Count; i++)
            {
                hs.Add(paths[i][0]);
            }

            for (int i = 0; i < paths.Count; i++)
            {
                // Checking in hashset, if found in hashset that means it forms a cycle
                if (!hs.Contains(paths[i][1]))
                {
                    destinationCity = paths[i][1];
                    break;
                }
            }

            return destinationCity;
        }

        static void Main(string[] args)
        {
            string cityA = "jMgaf WaWA";
            string cityB = "iinynVdmBz";
            string cityC = " QCrEFBcAw";
            string cityD = "wRPRHznLWS";
            string cityE = "OoLjlLFzjz";
            string cityF = "IhxjNbDeXk";
            string cityG = "jmuAYy vgz";

            string res1 = DestCity(new [] {
                new List<string> { cityA, cityB },
                new List<string> { cityC, cityD },
                new List<string> { cityB, cityE },
                new List<string> { cityE, cityC },
                new List<string> { cityF, cityA },
                new List<string> { cityG, cityF }
            });

            string res2 = DestCity(new[]
            {
                new List<string> { "London", "New York" },
                new List<string> { "New York", "Lima" },
                new List<string> { "Lima", "Sao Paulo" }
            });

            string res3 = DestCity(new[]
            {
                new List<string> {"B", "C" },
                new List<string> { "D", "B" },
                new List<string> { "C", "A" }
            });

            string res4 = DestCity(new[]
            {
                new List<string> { "A","Z" }
            });

            string res5 = DestCity(new[]
            {
                new List<string> { "pYyNGfBYbm", "wxAscRuzOl" },
                new List<string> { "kzwEQHfwce", "pYyNGfBYbm" }
            });
        }
    }
}
