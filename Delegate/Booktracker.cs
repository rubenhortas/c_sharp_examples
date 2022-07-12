using System.Collections.Generic;

namespace Delegate
{
    public delegate void AddBookCallback(int i);

    public class Booktracker
    {
        private List<string> _books = new List<string>();

        public void AddBook(string name, AddBookCallback callback)
        {
            _books.Add(name);
            callback(_books.Count);
        }
    }
}
