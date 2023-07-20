namespace Lab6Zoo
{
    abstract class Reptile : Animal
    {
        public string ScaleColor { get; set; }
        public int TailSize { get; set; }

        public abstract void Sound();
    }
}
