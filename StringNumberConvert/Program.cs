namespace StringNumberConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi string: ");
            string inputString = Console.ReadLine();

            int decimalNumber = Convert.ToInt32(inputString, 2);

            Console.WriteLine($"Desetichno e: {decimalNumber}");
        }
    }
}
