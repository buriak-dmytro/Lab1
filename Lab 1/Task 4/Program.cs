namespace Task_4
{
    internal delegate double CallbackMember(int sequenceNumber);

    internal class Program
    {
        static double CalculateFactorial(int number)
        {
            int factorial = 1;

            while (number != 1)
            {
                factorial *= number;
                number--;
            }

            return factorial;
        }

        public static double CalculateSequenceSum(CallbackMember memberNext, double epsilon)
        {
            double sum = 0;
            double sumCurrent = 0;
            int numberOfSequence = 1;

            do
            {
                sum = sumCurrent;
                sumCurrent += memberNext(++numberOfSequence);
            } while (Math.Abs(sumCurrent - sum) > epsilon);

            return sum;
        }

        static void Main(string[] args)
        {
            double epsilon = 0.001;

            CallbackMember memberFormula1 = 
                (int n) => { return (1.0 / (Math.Pow(2, n))); };
            CallbackMember memberFormula2 = 
                (int n) => { return (1.0 / CalculateFactorial(n)); };
            CallbackMember memberFormula3 = 
                (int n) => { return (Math.Pow(-1, n) * (1.0 / (Math.Pow(2, n)))); };

            Console.WriteLine(CalculateSequenceSum(memberFormula1, epsilon));
            Console.WriteLine(CalculateSequenceSum(memberFormula2, epsilon));
            Console.WriteLine(CalculateSequenceSum(memberFormula3, epsilon));

            Console.ReadLine();
        }
    }
}
