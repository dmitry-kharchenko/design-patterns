namespace DesignPatterns.Gof.AbstractFactory
{
    interface IFishingFactory
    {
        Hook GetHook();
        Reel GetReel();
    }
}
