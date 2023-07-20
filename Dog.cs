namespace Lab6Zoo
{
    class Dog : Mammal, IWalks
    {
        public int Legs { get; set; }

        public void Walk()
        {
            Console.WriteLine("Zooom!");
        }
    }
}
