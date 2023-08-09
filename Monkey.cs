using Lab6Zoo;

namespace Lab6Zoo
{
    class Monkey : Mammal
    {
        public void ClimbTree()
        {
            Console.WriteLine("Climb!!!");
        }

        public override void Move()
        {
            Console.WriteLine("Move like a monkey!");
        }
    }
}


class Monkey : Mammal, IClimbs
{
    public int Arms { get; set; }

    public void Climb()
    {
        Console.WriteLine("Climbing up!");
    }

}
