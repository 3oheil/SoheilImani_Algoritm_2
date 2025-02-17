namespace Number_One_Project
{
    public class Program
    {
        static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number %i == 0) return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            Console.Write("Please Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(number))
                Console.WriteLine($"{number} is a Prime number...");
            else
                Console.WriteLine($"{number} is not a Prime number...");
        }
    }
}
