namespace Reverse_Number_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            Console.WriteLine($"reversed number is {reverse}");
        }
    }
}
