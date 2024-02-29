// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Tracing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Patterns.BuilderPattern;
using Patterns.Configuration;
using Patterns.ObserverPattern;
using Patterns.StrategyPattern;

using var host = Host.CreateDefaultBuilder(args).ConfigureServices((_, services) => { services.AddServices(); })
    .Build();

//var test = IsPalindrome("A man, a plan, a canal: Panama");

var carBuilder = new CarBuilder();
var car = carBuilder
    .AddChassis("2024Master")
    .AddColor("Pink")
    .Build();

//delegates

Console.WriteLine($"ENG: {car.Engine}, Chassis: {car.Chassis} Color: {car.Color}");
Console.Read();

PrintEventHandler printDelegate = (string text) =>
{
    Console.WriteLine(text);
};

printDelegate("test");

public class BaseEntity
{
    public string Name { get; set; }

    //public abstract void TestMethod();

    public sealed virtual void MyMethod2()
    {
        Console.WriteLine("test");
    }

    public virtual void TestMethod3()
    {
        Console.WriteLine("test");
    }
    
}
delegate void PrintEventHandler(string text);

// static bool IsPalindrome(string s)
// {
//     for (int i = 0, j = s.Length - 1; j > i;)
//     {
//         if (!char.IsLetterOrDigit(s[i]))
//         {
//             i++;
//             continue;
//         }
//
//         if (!char.IsLetterOrDigit(s[j]))
//         {
//             j--;
//             continue;
//         }
//         
//         if (char.ToLower(s[i]) != char.ToLower(s[j]))
//         {
//             return false;
//         }
//
//         i++;
//         j--;
//         // var t = i++;
//         // var t2 = j--;
//         // Console.WriteLine($"{s[t]} - {s[t2]}");
//     }
//
//     return true;
// }
//
//
#region Synchronization
//
// var obj = new LockDisplay();
// var task1 = Task.Run(() => obj.DisplayNum());
// var task2 = Task.Run(() => obj.DisplayNum());
// var task3 = Task.Run(() => obj.DisplayNum());
//
// await Task.WhenAll(task1, task2, task3);
//
// public class Car : IDisposable
// {
//     private StringReader reader;
//
//     // to detect redundant calls
//     private bool disposed = false;
//
//     public Car()
//     {
//         this.reader = new StringReader("");
//     }
//
//     protected virtual void Dispose(bool disposing)
//     {
//         if (!disposed)
//         {
//             if (disposing)
//             {
//                 if (reader != null)
//                 {
//                     this.reader.Dispose();
//                 }
//             }
//
//             disposed = true;
//         }
//     }
//
//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }
// }
//
// internal class LockDisplay : IDisposable
// {
//     ~LockDisplay()
//     {
//     }
//
//     private readonly SemaphoreSlim semaphore = new(1);
//
//     public void DisplayNum()
//     {
//         lock (this)
//         {
//             ComputeAsync();
//         }
//     }
//
//     private void ComputeAsync()
//     {
//         for (var i = 1; i <= 5; i++)
//         {
//             Task.Delay(100);
//             Console.WriteLine("i = {0}", i);
//         }
//     }
//
//     private void Dispose(bool disposing)
//     {
//         if (disposing)
//         {
//             semaphore.Dispose();
//         }
//     }
//
//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }
// }

#endregion

#region Delegates

// var x = new MyClass();
// x.LongRunningProcess(Receiver);
//
// static void Receiver(int i)
// {
//     Console.WriteLine(i);
// }
//
// public class MyClass
// {
//     public delegate void Callback(int i);
//     public void LongRunningProcess(Callback callback)
//     {
//         for (var i = 0; i < 1000; i++)
//         {
//             Thread.Sleep(200);
//             callback(i);
//         }
//     }
// }

#endregion

// void StrategyPattern(IHost host1)
// {
//     var contacts = new List<string> { "contact1", "contact2", "contact3"};
//     var exportService = host1.Services.GetRequiredService<IExportService>();
//     var exportResult = exportService.Export("json", contacts);
//
//     Console.WriteLine(exportResult);
// }
//
// void ObserverPattern()
// {
//     // Configure Observer pattern
//     Teamlyzer s = new();
//     s.Attach(new Farfetcher("Marcos"));
//     s.Attach(new Farfetcher("Evandro"));
//     s.Attach(new Farfetcher("Mohamed"));
//     // Change subject and notify observers
//     s.Notice = "Bom Kin is here";
//     s.Notice = "Neves is out";
//     Console.ReadKey();
// }

// public class User
// {
//     //runtime 
//     private readonly int readonly1 = 100;
//     //can be initiated without value
//     private readonly int readonly2; 
//     
//     public User(int number)
//     {
//         //can only be changed inside constructor
//         this.readonly2 = 100 * number; 
//     }
// }

// public class User
// {
//     //compile time 
//     const int const1 = 100;
//     //needs to be initiated 
//     private const int const2; 
//     
//     public User(int number)
//     {
//         //can't change the value of const
//         this.const1 = 100 * number; 
//     }
// }

//StrategyPattern(host);
//ObserverPattern();