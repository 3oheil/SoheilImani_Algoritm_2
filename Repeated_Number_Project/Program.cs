namespace Repeated_Number_Project
{
    public class Program
    {
        static bool HasDuplicate(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {

                if (!seen.Add(num))
                {
                    return true;
                }
            }

            return false;

            static void Main(string[] args)
            {
                Console.Write("enter numbers to array and sorted by space: ");
                string input = Console.ReadLine();

                int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

                if (HasDuplicate(numbers))
                {
                    Console.WriteLine("There is a duplicate number");
                }
                else
                {
                    Console.WriteLine("There is no a duplicate number");
                }
            }
        }
    }
}
