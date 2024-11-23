namespace LoggerSingleton
{
    public class SimpleLogger
    {
        private static SimpleLogger simpleLogger;

        private SimpleLogger()
        {
            Console.WriteLine("Create new instance in contructor");
        }

        public static SimpleLogger GetInstance()
        {
            if (simpleLogger == null)
            {
                Console.WriteLine("SimpleLogger is null create new one");

                simpleLogger = new SimpleLogger();
                return simpleLogger;
            }

            Console.WriteLine("SimpleLogger is not null just return");
            return simpleLogger;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}