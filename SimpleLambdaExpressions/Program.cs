using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TraditionalDelegateSyntax();
            AnonymusMethodesSyntax();
            LyabdaExprestionSyntax();
        }
        static public void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 2, 3, 6, 47, 25, 31, 14 });
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
        static public bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
        static void AnonymusMethodesSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 2, 3, 6, 47, 25, 31, 14 });
            List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
        static void LyabdaExprestionSyntax()
        {
            List<int> ints = new List<int>();
            ints.AddRange(new int[] { 2, 3, 6, 32, 65, 4, 24, 2, 4 });
            List<int> evenNumbers = ints.FindAll((i) =>
            {
                Console.WriteLine($"Value of I is currently: {i} ");
                bool my=((i%2) == 0);
                return my;

            });
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
    }
}
