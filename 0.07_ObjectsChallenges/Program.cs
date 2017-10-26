﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Instantiation
            Netflix theOffice = new Netflix();
            Netflix strangerThings = new Netflix();
            Netflix theItCrowd = new Netflix();

            // Set Object Values
            theOffice.Name = "The Office";
            theOffice.Genre = "Comedy";
            theOffice.Rating = 5.0;

            strangerThings.Name = "Stranger Things";
            strangerThings.Genre = "Horror?";
            strangerThings.Rating = 4.6;

            theItCrowd.Name = "The IT Crowd";
            theItCrowd.Genre = "Humour";
            theItCrowd.Rating = 1.5;

            // Calling the methods (invoking, executing functions/methods)
            theOffice.GetSuggestion();
            strangerThings.GetSuggestion();
            theItCrowd.GetSuggestion();

            // Creating a list of Objects
            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(theOffice);
            favoriteShows.Add(strangerThings); 
            favoriteShows.Add(theItCrowd);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine($"Show Name: {show.Name} | Genre: {show.Genre} | Rating: {show.Rating}.");
            }

            Console.ReadLine();
        }
    }
}
