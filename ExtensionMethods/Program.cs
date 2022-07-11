using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            AntiHero superHero = new AntiHero { Name = "Johnny Blaze", SecretIdentity = "Ghost Rider" };
            superHero.SayName();
            superHero.RevealSecretIdentity();
            
            // Extension method.
            superHero.Uncover();
            
            Console.ReadLine();
        }
    }
}
