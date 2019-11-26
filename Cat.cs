using System;

namespace reviewSession
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string LegCount { get; set; }

        public void Eat()
        {
            Console.WriteLine("soft eating noises");
        }

        public void MakeSound()
        {
            Console.WriteLine("MRRROOOWWWWWWW");
        }

        public void Sleep()
        {
            Console.WriteLine("zzzzz...");
        }
    }
}