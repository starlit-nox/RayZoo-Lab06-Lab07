namespace Lab6Zoo
{
    abstract class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("ZZzzzzz");
        }
        public virtual void Move()
        {
            Console.WriteLine("Move Forward!!");
        }

        public virtual void Breathe()
        {
            Console.WriteLine("Just breathe!!");
        }
    }
}