namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi string:");
            string input = Console.ReadLine();

            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    Console.WriteLine("Stringa ne e palindrom.");
                    return;
                }
            }

            Console.WriteLine("Stringa e palindrom.");
        }
    }
}
