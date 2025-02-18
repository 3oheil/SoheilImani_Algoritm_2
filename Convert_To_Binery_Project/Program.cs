namespace Convert_To_Binery_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(number, 2);

            Console.WriteLine($"Binery representation: {binary}");
        }
    }
}
