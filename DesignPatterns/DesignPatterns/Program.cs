using DesignPatterns;

Singleton singleton1 = Singleton.GetSingleton;
Singleton singleton2 = Singleton.GetSingleton;

singleton1.Print("From singleton1!");
singleton2.Print("From singleton2!");

Console.ReadLine();