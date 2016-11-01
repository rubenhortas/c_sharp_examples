using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a char many times
            string s1 = new string('*', 25);
            Console.WriteLine(s1);

            // Interpolation strings
            string minion = "Mini Me";
            string evilGenius = "Dr. Evil";

            string s2 = $"{evilGenius} has a minion called {minion}";
            Console.WriteLine(s2);

            Console.ReadLine();
        }
    }
}
