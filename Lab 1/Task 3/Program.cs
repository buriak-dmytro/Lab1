using System;

namespace Task_3
{
    internal class Program
    {
        public static Random randGen = new Random();

        static void OutputArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = 20;

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                array1[i] = randGen.Next(-500, 501);
                array2[i] = randGen.Next(-500, 501);
            }

            Console.Write("array1: ");
            OutputArray(array1);

            Console.Write("array2: ");
            OutputArray(array2);

            Console.WriteLine();

            Predicate<int> predicate1 = (int number) => { return number % 3 == 0; };
            Predicate<int> predicate2 = (int number) => { return number % 7 == 0; };

            int[] array1Mod3Is0 = Array.FindAll(array1, predicate1);
            int[] array2Mod7Is0 = Array.FindAll(array2, predicate2);

            Console.Write("array1Mod3Is0: ");
            OutputArray(array1Mod3Is0);

            Console.Write("array2Mod7Is0: ");
            OutputArray(array2Mod7Is0);

            Console.ReadLine();
        }
    }
}
