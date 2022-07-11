using System;
using System.ComponentModel;
using System.Reflection;

namespace Enum
{
    class Program
    {
        private enum Numbers
        {
            [Description("Number One")] One,
            [Description("Number Two")] Two,
            [Description("Number Three")] Three
        }

        private static string GetEnumDescription(System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        static void Main()
        {
            foreach (System.Enum number in System.Enum.GetValues(typeof(Numbers)))
            {
                Console.WriteLine(GetEnumDescription(number));
            }

            Console.ReadLine();
        }
    }
}
