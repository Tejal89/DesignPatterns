namespace DesignPatterns.Singleton
{
    internal class DemoSingleton
    {
        private static LogProvider _logProvider;

        internal static void Process()
        {
            Console.WriteLine("First Instance Call, intialization should occur");
            _logProvider = LogProvider.Getinstance();
            _logProvider.LogMessage("Message to Console");

            Console.WriteLine("**********************************");
            Console.WriteLine("Second Instance Call, intialization should not occur");
            _logProvider = LogProvider.Getinstance();
            _logProvider.LogMessage("Message 2 to Console");
        }
    }
}
