using System;
using System.Text;

namespace T._05_HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string header = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder htmlFormat = new StringBuilder();

            htmlFormat.AppendLine($"<h1>\n    {header}\n</h1>");
            htmlFormat.AppendLine($"<article>\n    {content}\n</article>");

            string comment;
            while ((comment = Console.ReadLine()) != "end of comments")
            {
                htmlFormat.AppendLine($"<div>\n    {comment}\n</div>");
            }

            Console.WriteLine(htmlFormat);
        }
    }
}
