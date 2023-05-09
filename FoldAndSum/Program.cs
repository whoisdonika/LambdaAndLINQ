using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int k = nums.Length / 4;

            double[] left = nums.Take(k).Reverse().ToArray();
            double[] right = nums.Reverse().Take(k).ToArray();

            double[] row1 = left.Concat(right).ToArray();
            double[] row2 = nums.Skip(k).Take(2 * k).ToArray();

            double[] sum = row1.Select((x, index) => x + row2[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
    
}
