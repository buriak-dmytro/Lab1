using System;
using System.Security.Cryptography;

namespace Task_1
{
    internal delegate void CallbackWash(Car car);

    internal class Program
    {
        public static string[] manufacturerNames = { "Ford", "BMW", "Volvo", "Jaguar", "Subaru", "Renault" };
        public static string[] colorNames = { "red", "yellow", "grey", "black", "lime", "cyan", "white", "green"};

        public static Random randGen = new Random();

        public static string GenerateNumberPlate()
        {
            string toReturn = "";

            for (int i = 0; i < 8; i++)
            {
                toReturn += (char)(randGen.Next(1, 3) == 1 ? randGen.Next(48, 58) : randGen.Next(65, 91));
            }

            return toReturn;
            
        }

        static void Main(string[] args)
        {
            CallbackWash washCar = Washer.Wash;

            Garage garage = new Garage();

            for (int i = 0; i < 10; i++)
            {
                garage.Add(
                    new Car(
                        manufacturerNames[randGen.Next(0, manufacturerNames.Length)],
                        colorNames[randGen.Next(0, colorNames.Length)],
                        GenerateNumberPlate(),
                        randGen.Next(1, 3) == 1 ? true : false
                        )
                    );
            }

            Console.WriteLine(garage);
            Console.WriteLine();
            Console.WriteLine("We will wash those bad boys...");
            Console.WriteLine();

            foreach (var item in garage)
            {
                washCar(item);
            }

            Console.WriteLine(garage);

            Console.ReadLine();
        }
    }
}
