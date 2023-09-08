namespace NullCoalescingOperators
{
    class Program
    {
        // Null coalescingoperators: "??" and "??="c
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
        static void Main()
        {
            // The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result.
            // The ?? operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
            int? number = null;
            Console.WriteLine((number ?? 0)); // 0

            // The null-coalescing assignment operator ??= assigns the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null.
            // The ??= operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
            // The left-hand operand of the ??= operator must be a variable, a property, or an indexer element.
            List<int>? numbers = null;

            Console.WriteLine($"Is numbers null? {numbers is null}"); // true
            // If numbers is null initialize it
            numbers ??= new List<int>();
            Console.WriteLine($"Is numbers null? {numbers is null}"); // false
        }
    }
}