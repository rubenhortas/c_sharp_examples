using System;
using System.Globalization;
using System.Threading;

namespace Date
{
    public static class Temperature
    {
        public static void DisplayTemperature()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            Console.WriteLine($"Temperature at {DateTime.Now:HH:mm} on {DateTime.Now:MM/dd/yyyyy}: {25.45678:N2}F");
        }
    }
}
