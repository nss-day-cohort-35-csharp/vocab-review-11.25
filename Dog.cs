using System;

namespace reviewSession
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string LegCount { get; set; }

        public void Eat()
        {
            Console.WriteLine("Munch munch munch");
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark!");
        }

        public void Fetch(string fetchedItem)
        {
            Console.WriteLine($"{Name} fetched the {fetchedItem}!");
        }
    }
}