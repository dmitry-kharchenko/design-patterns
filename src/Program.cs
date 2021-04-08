using DesignPatterns.Gof.AbstractFactory;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory();
            Console.ReadLine();
        }

        #region Abstract Factory

        private static void AbstractFactory()
        {
            IFishingFactory carpFactory = new CarpFishingFactory();
            IFishingFactory bassFactory = new BassFishingFactory();

            var shopAssistant1 = new ShopAssistant();
            var shopAssistant2 = new ShopAssistant();

            List<object> carpFishingStuff = shopAssistant1.AssistCustomer(carpFactory);
            List<object> bassFishingStuff = shopAssistant2.AssistCustomer(bassFactory);
        }

        class ShopAssistant
        {
            public List<object> AssistCustomer(IFishingFactory factory)
            {
                // give a hook to customer
                Hook hook = factory.GetHook();
                Reel reel = factory.GetReel();

                Console.WriteLine($"Now I'm ready to go fishing! I've got {hook.Name} and {reel.Name}");

                return new List<object> { hook, reel };
            }
        }

        #endregion Abstract Factory
    }
}
