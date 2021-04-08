namespace DesignPatterns.Gof.AbstractFactory
{
    class CarpFishingFactory : IFishingFactory
    {
        public Hook GetHook()
        {
            return new CarpHook();
        }

        public Reel GetReel()
        {
            return new CarpReel();
        }
    }
}
