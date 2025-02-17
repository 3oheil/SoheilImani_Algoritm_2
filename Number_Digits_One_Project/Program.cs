namespace Number_Digits_One_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();   
            while (number > 0)
            {
                list.Add(number % 10);
                number = number / 10;
            }

            Console.WriteLine(list.Count());
        }
    }
}