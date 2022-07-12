using System;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static void Uncover(this AntiHero antiHero)
        {
            Console.WriteLine($"I'm {antiHero.Name}, and you can call me {antiHero.SecretIdentity}");
        }
    }
}
