using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = Console.ReadLine()
                .Split(' ');

            var words = morseCode.Where(x => x != '|'.ToString()).ToList();

            foreach (var word in words)
            {
                Console.Write(word + " ");
            }
        }
    }
}
