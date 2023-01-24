namespace ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            AntiHero antiHero = new AntiHero { Name = "Johnny Blaze", SecretIdentity = "Ghost Rider" };
            
            antiHero.SayName();
            antiHero.RevealSecretIdentity();

            // Extension method.
            antiHero.Uncover();
        }
    }
}
