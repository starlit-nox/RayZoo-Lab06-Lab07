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
