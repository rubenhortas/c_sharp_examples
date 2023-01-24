using System;

namespace String
{
    class Program
    {
        private const string Minion = "Mini Me";
        private const string EvilGenius = "Dr. Evil";
        private const string OneTwoThree = "one, two, three";
        private const string Numbers = "1234513370000";
        private const string Leet = "1337";
        private const string HelloWorld = "Hello, world!!";
        private static readonly string[] HelloWorldArray = { "hello", "world!" };

        static void Main()
        {
            Print('*', 25);
            PrintInterpolatedString();
            Join();
            Split();
            Contains();
            Remove();
        }

        private static void Print(char c, int times)
        {
            // Create a string made of c char n times.
            string str = new string(c, times);

            Console.WriteLine($"'{c}' {times} times: {str}");
        }

        private static void PrintInterpolatedString()
        {
            Console.WriteLine($"Interpolated string: \"{EvilGenius} has a minion called {Minion}\"");
        }

        private static void Join()
        {
            // This method is used to concatenate the members of a collection or the elements of the specified array,
            // using the specified separator between each member or element. 
            string joinedString = string.Join(",", HelloWorldArray);

            // Output: "hello,world!".
            Console.WriteLine($"Joined string: \"{joinedString}\"");
        }

        private static void Split()
        {
            string[] splittedString = OneTwoThree.Split();

            Console.WriteLine("Splitted string:");

            foreach (string str in splittedString)
            {
                Console.WriteLine($"\t{str}");
            }
        }

        private static void Contains()
        {
            if (Numbers.Contains(Leet))
            {
                Console.WriteLine($"\"{Numbers}\" contains \"{Leet}\". Y0u'r3 h4x0r!");
            }
        }

        private static void Remove()
        {
            // Remove last char.
            string cleanHelloWorld = HelloWorld.Remove(HelloWorld.Length - 1);

            // Output: "Hello, world!".
            Console.WriteLine($"Removing last char from \"{HelloWorld}\": \"{cleanHelloWorld}\"");
        }
    }
}
