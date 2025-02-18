namespace GCD
{
    public class Program
    {
        static int GCD(int firstNumber, int secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            while (secondNumber != 0)
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }
            return firstNumber;
        }

        static void Main(string[] args)
        {
            Console.Write("Please Give me first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Give me second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"GCD of {firstNumber} and {secondNumber} is ({GCD(firstNumber, secondNumber)})");
        }
    }
}
