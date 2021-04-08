namespace DesignPatterns.Gof.AbstractFactory
{
    abstract class Reel
    {
        public string Name { get; }

        protected Reel(string name) => Name = name;
    }

    class CarpReel : Reel
    {
        public CarpReel() : base("Carp reel") { }
    }

    class BassReel : Reel
    {
        public BassReel() : base("Bass reel") { }
    }
}
