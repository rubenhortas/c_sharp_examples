using System;

namespace String
{
    class Program
    {
        static void Main()
        {
            // Print a char many times
            string s1 = new string('*', 25);
            Console.WriteLine(s1);

            // Interpolation strings
            string minion = "Mini Me";
            string evilGenius = "Dr. Evil";

            string s2 = $"{evilGenius} has a minion called {minion}"; // Dr. Evil has a minion called Mini Me
            Console.WriteLine(s2);

            // Join
            // This method is used to concatenates the members of a collection or the elements of the specified array,
            // using the specified separator between each member or element. 
            string[] helloWorldArray = { "hello", "world!" };

            string joinedString = string.Join(",", helloWorldArray);
            Console.WriteLine(joinedString); // hello,world!

            // Split
            string str = "one, two, three";
            string[] splittedString = str.Split();

            foreach (string s in splittedString)
            {
                Console.WriteLine(s);
            }

            // Contains
            string numbers = "1234513370000";

            if (numbers.Contains("1337"))
            {
                Console.WriteLine("Y0u'r3 1337!"); // Y0u'r3 1337!
            }

            // Remove
            // Remove last char
            string helloWorld = "Hello, world!!";
            string cleanHelloWorld = helloWorld.Remove(helloWorld.Length - 1);
            Console.WriteLine(cleanHelloWorld); // Hello, world!

            Console.ReadLine();
        }
    }
}
