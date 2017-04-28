using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args) //foreach迴圈     -讀DB 或 陣列
        {
            Random randon = new Random();
            int[] numbers = new int[10];
            int total = 0;

            for (int index = 0; index < numbers.Length; index++)
            { numbers[index] = randon.Next(1, 101); }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);

                total += number;
            }
            Console.WriteLine("總和 = {0}", total);
        }
    }
}