using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int max = 2;
            int total = 0;
            int number = 1;
            while (total <= max)
            {
                total += number;
                number++;
            }
            Console.WriteLine("total = {0} number = {1}", total, number);
        }
    }
}