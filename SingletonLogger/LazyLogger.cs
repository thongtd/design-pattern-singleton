namespace LoggerSingleton
{
    public class LazyLogger
    {
        public static readonly Lazy<LazyLogger> lazyLogger = new Lazy<LazyLogger>(() => new LazyLogger());

        private LazyLogger()
        {
            Console.WriteLine("Create new instance in contructor");
        }

        public static LazyLogger GetInstance = lazyLogger.Value;

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}