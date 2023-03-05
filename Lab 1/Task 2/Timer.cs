using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal delegate void CallBackMethod(string row, int value);

    internal class Timer
    {
        private static int idOfUnnamed = 0;
        private string name;
        private int counter = 0;
        private int step;
        private CallBackMethod methodToCall;

        public Timer()
        {
            name = $"DefaulTimerName_{++idOfUnnamed}";
            step = 1000;
            methodToCall = 
                (name, counter) => 
                {
                    Console.WriteLine($"{name}: {counter}"); 
                };
        }

        public Timer(string name, int step, CallBackMethod methodToCall)
        {
            this.name = name;
            this.step = step;
            this.methodToCall = methodToCall;
        }

        public void CallMethod()
        {
            while (true)
            {
                methodToCall(name, counter);
                Thread.Sleep(step);
                counter += (step / 1000);
            }
        }
    }
}
