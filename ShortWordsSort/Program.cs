using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(chars, StringSplitOptions.RemoveEmptyEntries) // could've put separators there but it would make it too messy
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
