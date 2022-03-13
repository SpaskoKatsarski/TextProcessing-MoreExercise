using System;

namespace T01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int startOfTheNameIndex = input.IndexOf('@') + 1;
                string nameOfPerson = input.Substring(startOfTheNameIndex, input.IndexOf('|') - startOfTheNameIndex);

                int startOfTheAgeIndex = input.IndexOf('#') + 1;
                string ageOfPerson = input.Substring(startOfTheAgeIndex, input.IndexOf('*') - startOfTheAgeIndex);

                Console.WriteLine($"{nameOfPerson} is {ageOfPerson} years old.");
            }
        }
    }
}
