namespace StringVertikal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi izrecenie:");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
