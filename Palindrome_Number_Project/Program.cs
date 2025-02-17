namespace Palindrome_Number_Project
{
    public class Program
    {
        static bool IsPalindrome(int number)
        {
            if (number < 0) return false;
            int orginal= number;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number% 10;
                reversed = reversed*10+digit;
                number/=10;
            }

            return orginal == reversed;
        }


        static void Main(string[] args)
        {
            Console.Write("enter a number please: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(IsPalindrome(num))
                Console.WriteLine($"{num} is palindrome");
            else
            {
                Console.WriteLine($"{num} is not palindrome");
            }
        }
    }
}
