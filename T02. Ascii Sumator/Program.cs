using System;

namespace T02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());

            string randomString = Console.ReadLine();

            int valueOfBiggerChar = Math.Max(firstCh, secondCh);

            char biggerChar;
            char smallerChar;

            if (firstCh == valueOfBiggerChar)
            {
                biggerChar = firstCh;
                smallerChar = secondCh;
            }
            else
            {
                biggerChar = secondCh;
                smallerChar = firstCh;
            }


        }
    }
}
