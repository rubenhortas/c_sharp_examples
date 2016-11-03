using System;

namespace ExtensionMethods
{
    public class AntiHero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }

        public void SayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void RevealSecretIdentity()
        {
            Console.WriteLine($"I'm {SecretIdentity}");
        }
    }
}
