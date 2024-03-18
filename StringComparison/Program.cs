namespace StringComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi 1 string:");
            string str1 = Console.ReadLine().ToLower(); 
            Console.WriteLine("Vuvedi 2 string:");
            string str2 = Console.ReadLine().ToLower();

            int comparisonResult = string.Compare(str1, str2);

            if (comparisonResult < 0)
            {
                Console.WriteLine("Purviq e po golqm ot vtoriq");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("Vtoriq e po golqm ot purviq.");
            }
            else
            {
                Console.WriteLine("Dvata sa ednakvi.");
            }
        }
    }
}
