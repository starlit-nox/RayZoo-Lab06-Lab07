namespace Lab6Zoo
{
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog
            {
                FurColor = "Gray"
            };
            dog.Sleep();
            dog.Breathe();
            dog.Move();
            dog.Walk();

            Monkey monkey = new Monkey
            {
                FurColor = "Spotted"
            };
            monkey.Sleep();
            monkey.Breathe();
            monkey.Move();
            monkey.ClimbTree();
        }
    }
}