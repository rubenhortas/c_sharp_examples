using System;
using System.Globalization;
using System.Threading;

namespace Date
{
    public static class Temperature
    {
        private const decimal Temp = 25.45678M;
        public static void DisplayTemperature()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            Console.WriteLine($"Temperature at {DateTime.Now:HH:mm} on {DateTime.Now:MM/dd/yyyyy}: {Temp:N2}ºF");
        }
    }
}
