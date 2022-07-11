using System;

namespace Delegate
{
    public class Runner
    {
        Booktracker booktracker = new Booktracker();

        public void Add(string name)
        {
            booktracker.AddBook(name, delegate (int i)
            {
                Console.WriteLine($"{name} {i}");
            });
        }
    }
}
