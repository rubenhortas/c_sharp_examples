using System;

namespace log4net_example
{
    // Steps:
    // 1) Add [assembly: log4net.Config.XmlConfigurator(Watch=true)] to AssemblyInfo.cs
    //    This way log4net will know that it can look for configuration in the default application config file
    // 2) Add <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net"/> to App.config
    //    This time log4net will know that the real configuration is stored in XML node called log4net
    // 3) Add section log4net to App.config
    // 4) Configure logging level in App.config
    // 5) Configure appender[s] and add the appender[s] section[s]

    class Program
    {
        private static readonly log4net.ILog s_log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main()
        {
            Console.WriteLine($"System.Reflection.MethodBase.GetCurrentMethod().DeclaringType: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType}");
            s_log.Fatal("Fatal");
            s_log.Error("Error");
            s_log.Warn("Warn");
            s_log.Info("Info");
            s_log.Debug("Debug");
        }
    }
}
