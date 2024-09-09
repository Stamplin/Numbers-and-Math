using System.Dynamic;
//Numbers and Math lesson
namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) How much money would you make if you were to work for 8 hours while earning $21/hour?");

            Console.WriteLine((8 * 21).ToString("C"));
            Console.WriteLine("")

            Console.WriteLine("2) How much would a dozen (12) eggs cost if one egg is 6$?");
            Console.WriteLine("$" + (6 * 12));
            Console.WriteLine("");
            
            Console.WriteLine("3) What is the 13% tax of $79.99?");
            Console.WriteLine("$" + (79.99*0.13));
            Console.WriteLine("");

            Console.WriteLine("What is 5'6 in cm?");
            Console.WriteLine((2.54 * 12 * 5) + (6 * 2.54) + "cm");
        }
    }
}
