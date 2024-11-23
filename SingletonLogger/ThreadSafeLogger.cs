namespace LoggerSingleton
{
    public class ThreadSafeLogger
    {
        private static ThreadSafeLogger threadSafeLogger;
        private static readonly object lockObject = new object();

        private ThreadSafeLogger()
        {
            Console.WriteLine("Create new instance in contructor");
        }

        public static ThreadSafeLogger GetInstance()
        {
            if (threadSafeLogger == null)
            {
                lock (lockObject)
                {
                    if (threadSafeLogger == null)
                    {
                        Console.WriteLine("ThreadSafeLogger is null create new one");

                        threadSafeLogger = new ThreadSafeLogger();
                        return threadSafeLogger;
                    }
                }
            }

            Console.WriteLine("ThreadSafeLogger is not null just return");
            return threadSafeLogger;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}