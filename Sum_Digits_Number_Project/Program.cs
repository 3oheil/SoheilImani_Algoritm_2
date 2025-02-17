namespace Sum_Digits_Number_Project
{
    public class Program
    {
        static int SumOfDigit(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;

        }

        static void Main(string[] args)
        {
            Console.Write("Give me a number please: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"sum of Digit is {SumOfDigit(num)}");
        }
    }
}
