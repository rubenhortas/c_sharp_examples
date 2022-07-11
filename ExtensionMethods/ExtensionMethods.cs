using System;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static void Uncover(this AntiHero superHero)
        {
            Console.WriteLine($"I'm {superHero.Name}, and you can call me {superHero.SecretIdentity}");
        }
    }
}
