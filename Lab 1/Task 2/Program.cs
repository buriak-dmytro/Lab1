using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Task_2
{
    internal static class ContainerOfMethods
    {
        public static void Method1(string row, int value)
        {
            Console.WriteLine($"Timer name: {row}; Seconds passed: {value}");
        }

        public static void Method2(string row, int value)
        {
            Console.WriteLine($"{row}; {value} sec");
        }

        public static void Method3(string row, int value)
        {
            Console.WriteLine($"Method3; Name: {row}; Seconds: {value}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer1 = new Timer("clocker1", 3000, ContainerOfMethods.Method1);
            Timer timer2 = new Timer("timer2", 7000, ContainerOfMethods.Method2);
            Timer timer3 = new Timer("waiter3", 10000, ContainerOfMethods.Method3);

            Thread thread1 = new Thread(new ThreadStart(timer1.CallMethod)); // method that executes on a Thread
            Thread thread2 = new Thread(new ThreadStart(timer2.CallMethod)); // method that executes on a Thread
            Thread thread3 = new Thread(new ThreadStart(timer3.CallMethod)); // method that executes on a Thread

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
