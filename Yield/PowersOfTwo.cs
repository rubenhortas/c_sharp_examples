using System;
using System.Collections.Generic;

  // When you use the yield contextual keyword in a statement, you indicate that the method, 
  // operator, or get accessor in which it appears is an iterator. Using yield to define an iterator 
  // removes the need for an explicit extra class (the class that holds the state for an enumeration, 
  // see IEnumerator<T> for an example) when you implement the IEnumerable and IEnumerator pattern for 
  // a custom collection type.

 // Use a yield return statement to return each element one at a time.
namespace Yield
{
    public static class PowersOfTwo
    {
        public static void Start()
        {
            // Display powers of 2 up to the exponent of 8.
            foreach (int i in Power(2, 8))
            {
                Console.Write($"{i}");
            }
        }

        private static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= number;

                // Use a yield return statement to return each element one at a time.
                yield return result;
            }
        }
    }
}
