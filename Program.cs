using System;

namespace MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter first string");
            String word1 = Console.ReadLine();

            Console.WriteLine("Enter second string");
            String word2 = Console.ReadLine();

            String resultString = "";
            String char1 = "";
            String char2 = "";
            int length = 0;
            int greaterLength = 0;
            String bigString = "";
            if (word1.Length < word2.Length)
            {
                length = word1.Length;
                greaterLength = word2.Length;
                bigString = word2;
            }
            else
            {
                length = word2.Length;
                greaterLength = word1.Length;
                bigString = word1;
            }


            for (int i = 0; i <= length - 1; i++)
            {
                char c = word1[i];

                char s = word2[i];

                char1 = c.ToString();
                char2 = s.ToString();

                resultString = resultString + char1 + char2;
            }
            for (int j = length; j <= greaterLength - 1; j++)
            {
                resultString = resultString + bigString[j];
            }
            Console.WriteLine("Result String is :" + resultString);


            Console.WriteLine("Bye");
            
        }
    }
}
