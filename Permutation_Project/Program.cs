namespace Permutation_Project
{
    public class Program
    {
        static void GeneratePermutations(string str)
        {
            var result = GetPermutations(str.ToCharArray(), 0, str.Length - 1);
            foreach (var item in result)
            {
                Console.WriteLine(new string(item));
            }
        }

        static char[][] GetPermutations(char[] array, int l, int r)
        {
            var result = new List<char[]>();

            if (l == r)
            {
                result.Add((char[])array.Clone());
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    Swap(array, l, i);
                    result.AddRange(GetPermutations(array, l + 1, r));
                    Swap(array, l, i);
                }
            }

            return result.ToArray();
        }

        static void Swap(char[] array, int i, int j)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();

            GeneratePermutations(input);
        }
    }
}

