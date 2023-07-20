namespace Lab6Zoo
{
    class Gecko : Reptile
    {
        public Gecko()
        {
            ScaleColor = "Brown";
            TailSize = 5;
        }
        public override void Breathe()
        {
            Console.WriteLine("Gecko Breathes!!");
        }
        public override void Sound()
        {
            Console.WriteLine("Hissssss");
        }

        void SellInsurance()
        {
            Console.WriteLine("15 minutes can save you 15 percent or more on car insurance!!");
        }
    }
}
