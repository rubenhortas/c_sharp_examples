using System;
using System.ComponentModel;
using System.Reflection;

namespace enums
{
    class Program
    {
        private enum Numbers
        {
            [Description("Number One")] One,
            [Description("Number Two")] Two,
            [Description("Number Three")] Three
        }

        private static string GetEnumDescription(Enum value)
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
            foreach (Enum number in Enum.GetValues(typeof(Numbers)))
            {
                Console.WriteLine(GetEnumDescription(number));
            }

            Console.ReadLine();
        }
    }
}
