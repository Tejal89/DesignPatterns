
namespace DesignPatterns.Singleton
{
    internal sealed class LogProvider
    { 
        private static Lazy<LogProvider> _provider = new Lazy<LogProvider>(() => new LogProvider());

        public static LogProvider Getinstance() => _provider.Value;

        private LogProvider() {
            Console.WriteLine("Log Provider Initialized");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    
}
