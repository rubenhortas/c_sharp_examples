using System;

namespace Delegate
{
    public class Runner
    {
        private Booktracker _booktracker = new Booktracker();

        public void Add(string name)
        {
            _booktracker.AddBook(name, delegate (int i)
            {
                Console.WriteLine($"{name} {i}");
            });
        }
    }
}
