namespace reviewSession
{
    public interface IAnimal
    {
        string Name { get; set; }
        string LegCount { get; set; }
        void Eat();
        void MakeSound();
    }
}