using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args) //for 迴圈
        {
            Console.Write("1+2+3+4....+??   請輸入?? :");
            int end = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            string result = "";
            string dot = "";
            for (int i = 1; i <= end; i++)
            {
                if (i <= 5)
                {
                    result = result + string.Format("{0} + ", i);
                }
                else if (i > 5 && i < end)
                {
                    dot = "... + ";
                }
                else
                    result = result + string.Format("{0}{1} = ", dot, i);

                total += i;
            }
            Console.WriteLine(result + total);
        }
    }
}