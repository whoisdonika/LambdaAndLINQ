using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__min__max__avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
