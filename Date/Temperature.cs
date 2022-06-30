using System;
using System.Globalization;
using System.Threading;

namespace DateFormatting
{
    public static class Temperature
    {
        public static void DisplayTemperature()
        {
            //modify the vlaue of en-us to Culture.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            Console.WriteLine(string.Format("Temperature at {0:t} on {0:d} {1:N2}",DateTime.Now, 25.45678));
        }
    }
}
