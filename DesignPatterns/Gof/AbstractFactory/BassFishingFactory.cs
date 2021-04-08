namespace DesignPatterns.Gof.AbstractFactory
{
    class BassFishingFactory : IFishingFactory
    {
        public Hook GetHook()
        {
            return new BassHook();
        }

        public Reel GetReel()
        {
            return new BassReel();
        }
    }
}
