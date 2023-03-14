using DesignPatterns;


Parallel.Invoke(
    () => Print1(), 
    () => Print2()
    );

static void Print2()
{
    Singleton singleton1 = Singleton.GetSingleton;
    singleton1.Print("From singleton1!");
    Console.ReadLine();
}

static void Print1()
{
    Singleton singleton2 = Singleton.GetSingleton;
    singleton2.Print("From singleton2!");
    Console.ReadLine();
}
