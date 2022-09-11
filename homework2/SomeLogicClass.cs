using System.Collections.Concurrent;

namespace ConsoleApp1;

public class SomeLogicClass
{
    private static Mutex _mutex = new();   //new data type

    
    public static void SomeLogicMethod(object? b)
    {
        _mutex.WaitOne();

        Console.ForegroundColor = ConsoleColor.Green;
        
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}, {Thread.CurrentThread.Name} entered");
        
        Console.ResetColor();
        
        ConcurrentDictionary<int, string> threadSafetyDictionary = new ConcurrentDictionary<int, string>();

        bool a = threadSafetyDictionary.TryAdd(1, "foo");
        
        if (a)
            Console.WriteLine("1 foo added");
        
        a =threadSafetyDictionary.TryAdd(2, "test");
        
        if (a)
            Console.WriteLine("2 test added");
        
        a =threadSafetyDictionary.TryAdd(3, "abc");
        
        if (a)
            Console.WriteLine("3 abc added");
        
        a =threadSafetyDictionary.TryRemove(3, out string abc);
        
        if (a)
            Console.WriteLine("3 abc removed");

        a = threadSafetyDictionary.TryUpdate(2,"test2", "test");
        
        if (a)
            Console.WriteLine("2 test updated to test2");

        _mutex.ReleaseMutex();
    }
}