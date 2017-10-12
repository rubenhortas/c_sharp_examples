using System;

namespace DelegateExample
{
    public class Runner
    {
        Booktracker booktracker = new Booktracker();
        public void Add(string name)
        {
            booktracker.AddBook(name, delegate (int i)
            {
                Console.WriteLine(string.Format("{0} {1}",name, i.ToString()));
            });
        }
    }
}
