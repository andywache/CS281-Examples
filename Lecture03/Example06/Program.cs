using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1+100 累加
            int total = 0;
            for (int i = 1; i < 100; i++)
            {
                Console.Write(i + "+");
                total += i;
                if (i == 100) { Console.Write(i + "="); }
            }
            Console.WriteLine(total);
        }
    }
}