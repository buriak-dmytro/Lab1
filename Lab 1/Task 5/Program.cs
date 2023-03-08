using System.Linq;
using System.Collections.Generic;

namespace Task_5
{
    internal delegate double OperateOnNumber(double number);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rules of using:");
            Console.WriteLine("_ _ - enter two numbers to execute command");
            Console.WriteLine("First _ - 0, 1, 2 for (sqrt(abs(x))), (x^3), (x + 3.5)");
            Console.WriteLine("Second _ - pass a number");
            Console.WriteLine("Enter below:");

            List<OperateOnNumber> operations = new List<OperateOnNumber>
            {
                (number) => { return  Math.Sqrt(Math.Abs(number)); },
                (number) => { return Math.Pow(number, 3); },
                (number) => { return number + 3.5; }
            };

            bool isContinueLoop = true;
            while (isContinueLoop)
            {
                try
                {
                    string[] inputDataStr = Console.ReadLine().Split();
                    int index = int.Parse(inputDataStr[0]);
                    int number = int.Parse(inputDataStr[1]);

                    OperateOnNumber operation = operations[index];

                    Console.WriteLine(operation(number));
                }
                catch (Exception exception)
                {
                    isContinueLoop = false;
                    Console.WriteLine("Error occured. Execution is over");
                }
            }

            Console.ReadLine();
        }
    }
}
