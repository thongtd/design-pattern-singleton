// See https://aka.ms/new-console-template for more information
using LoggerSingleton;

Console.WriteLine("Hello, World!");

// TestSimpleLogger();

//TestSimpleLoggerWithThread();

//TestThreadSafeLoggerWithThread();

TestLazyLoggerWithThread();

Console.ReadLine();

void TestSimpleLogger()
{
    var simpleLogger = SimpleLogger.GetInstance();

    simpleLogger.Log("Hi 1");

    var simpleLogger2 = SimpleLogger.GetInstance();
    simpleLogger2.Log("Hi 2");

    var simpleLogger3 = SimpleLogger.GetInstance();
    simpleLogger3.Log("Hi 3");
}

void TestSimpleLoggerWithThread()
{
    var thread1 = new Thread(() =>
    {
        var simpleLogger4 = SimpleLogger.GetInstance();
        simpleLogger4.Log("Hi 4");
    });

    var thread2 = new Thread(() =>
    {
        var simpleLogger5 = SimpleLogger.GetInstance();
        simpleLogger5.Log("Hi 5");
    });

    thread1.Start();
    thread2.Start();
}

void TestThreadSafeLoggerWithThread()
{
    var thread1 = new Thread(() =>
    {
        var simpleLogger4 = SimpleLogger.GetInstance();
        simpleLogger4.Log("Hi 4");
    });

    var thread2 = new Thread(() =>
    {
        var simpleLogger5 = SimpleLogger.GetInstance();
        simpleLogger5.Log("Hi 5");
    });

    thread1.Start();
    thread2.Start();
}

void TestLazyLoggerWithThread()
{
    var thread1 = new Thread(() =>
    {
        var simpleLogger4 = LazyLogger.GetInstance;
        simpleLogger4.Log("Hi 4");
    });

    var thread2 = new Thread(() =>
    {
        var simpleLogger5 = LazyLogger.GetInstance;
        simpleLogger5.Log("Hi 5");
    });

    thread1.Start();
    thread2.Start();
}