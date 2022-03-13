using System;

namespace T02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            int biggerCharValue = Math.Max(firstChar, secondChar);
            int smallerCharValue = Math.Min(firstChar, secondChar);

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int currentChar = text[i];

                if (currentChar > smallerCharValue && currentChar < biggerCharValue)
                {
                    sum += currentChar;
                }
            }

            Console.WriteLine(sum);


            //char firstCh = char.Parse(Console.ReadLine());
            //char secondCh = char.Parse(Console.ReadLine());

            //string randomString = Console.ReadLine();

            //int valueOfBiggerChar = Math.Max(firstCh, secondCh);

            //char biggerChar;
            //char smallerChar;

            //if (firstCh == valueOfBiggerChar)
            //{
            //    biggerChar = firstCh;
            //    smallerChar = secondCh;
            //}
            //else
            //{
            //    biggerChar = secondCh;
            //    smallerChar = firstCh;
            //}
        }
    }
}
