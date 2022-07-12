using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Enumerable.Range(1, 10).ToList();
            List<string> numberNames = new List<string> { "one", "two", "three", "four" };

            var firstNumberName = numberNames.First(nn => nn.StartsWith("t"));
            Console.WriteLine($"firstNumber: {firstNumberName}");

            var projection = from n in numbers
                             select new
                             {
                                 Even = (n % 2 == 0),
                                 Odd = !(n % 2 == 0),
                                 Value = n,
                             };

            var projectionEvens = projection.Where(p => p.Even);
            var evens = projectionEvens.Select(n => n.Value.ToString()).ToList();

            var projectionOdds = projection.Where(p => p.Odd).ToList();
            var odds = projectionOdds.Select(n => n.Value.ToString()).ToList();

            Console.WriteLine(string.Join(",", evens));
            Console.WriteLine(string.Join(",", odds));
        }
    }
}
