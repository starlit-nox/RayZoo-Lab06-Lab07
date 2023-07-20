using Lab6Zoo;

namespace Lab6
{
    class Ostrich : Bird, IWalks
    {
        public int Legs { get; set; }
        public void Walk()
        {
            Console.WriteLine("Meep meep");
        }
    }
}
