using System;
using System.Diagnostics;

namespace DebugAndTrace
{
    class Program
    {
        static void Main()
        {
            TextWriterTraceListener tr1 = new TextWriterTraceListener(Console.Out);
            Debug.Listeners.Add(tr1);

            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
            Debug.Listeners.Add(tr2);

            // Only in debug mode.
            LogDebug();

            // Debug and release mode.
            LogTrace();

            Console.ReadLine();
        }

        private static void LogDebug()
        {
            bool showAssert = true;

            Debug.WriteLine("Debug line");
            Debug.Indent();
            Debug.WriteLineIf(showAssert == true, "showAssert is true");
            // Debug.Assert(showAssert == true, "assert message");
            // Debug.Assert(showAssert == false, "no message beacuse showAssert is false");
            Debug.Unindent();
            Debug.Flush();
        }

        private static void LogTrace()
        {
            bool showAssert = true;

            Trace.WriteLine("Trace line");
            Trace.Indent();
            Trace.WriteLineIf(showAssert == true, "showAssert is true");
            // Trace.Assert(showAssert == true, "assert message");
            // Trace.Assert(showAssert == false, "no message because showAssert is false");
            Trace.Unindent();
            Trace.Flush();
        }
    }
}
