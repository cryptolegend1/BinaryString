using System;

namespace BinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new BinaryStringChecker();

            Console.WriteLine(checker.IsGood("11010"));
            Console.WriteLine(checker.IsGood("11100010"));
        }
    }
}
