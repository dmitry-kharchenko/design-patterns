namespace DesignPatterns.Gof.AbstractFactory
{
    abstract class Hook
    {
        public string Name { get;}

        protected Hook(string name) => Name = name;
    }

    class CarpHook : Hook
    {
        public CarpHook() : base("Carp hook") { }
    }

    class BassHook : Hook
    {
        public BassHook() : base("Bass hook") { }
    }
}
