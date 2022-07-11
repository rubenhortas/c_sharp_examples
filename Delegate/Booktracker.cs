using System.Collections.Generic;

namespace Delegate
{
    public delegate void AddBookCallback(int i);

    public class Booktracker
    {
        private List<string> books = new List<string>();

        public void AddBook(string name, AddBookCallback callback)
        {
            books.Add(name);
            callback(books.Count);
        }
    }
}
