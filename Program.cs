using System;
using System.Collections.Generic;
using System.Linq;

namespace reviewSession
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy gum = new Candy();

            gum.isSour = false;
            gum.Color = "pink";

            // check if gum obj is sour
            if(gum.isSour)
            {
                Console.WriteLine("The gum is sour!!");
            } else
            {
                Console.WriteLine("The gum is NOT sour 👎");
            }

            Candy taffy = new Candy()
            {
                Name = "laffy taffy",
                Flavor = "grape",
                Color = "purple",
                Weight = 4,
                isSour = false
            };

            Candy chocolate = new Candy()
            {
                Name = "Hershey's Kiss",
                Flavor = "chocolate",
                Color = "brown",
                Weight = 7,
                isSour = true
            };

            Candy lollipop = new Candy()
            {
                Name = "dum dum",
                Flavor = "blue raspberry",
                Color = "blue",
                Weight = 1,
                isSour = false
            };

            Candy sourPatchKids = new Candy()
            {
                Name = "Sour Patch Kids",
                Flavor = "All of them",
                Color = "All of them",
                Weight = 20,
                isSour = true
            };

            Candy nerds = new Candy()
            {
                Name = "nerds",
                Flavor = "All of them",
                Color = "All of them",
                Weight = 1,
                isSour = false
            };

            List<Candy> allCandies = new List<Candy>()
            {
                taffy, chocolate, sourPatchKids, lollipop, nerds, gum
            };

            // find candies that are sour
            List<Candy> sourCandies = allCandies.Where(c => c.isSour).ToList();

            // create a list of all the candy names
            List<string> names = allCandies.Select(c => c.Name).ToList();

            // grab the heaviest candy
            Candy heaviestCandy = allCandies.OrderBy(c => c.Weight).Last();

            // group candies by whether or not they are sour
            var groupedCandies = allCandies.GroupBy(c => c.isSour);

            foreach (var group in groupedCandies)
            {
                Console.WriteLine($"{group.Key} has {group.Count()} candies in it");
                foreach (var candy in group)
                {
                    Console.WriteLine($"{candy.Name} is {group.Key}");
                }
            }

        }
    }
}
