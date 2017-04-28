using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args) //for 迴圈
        {
            int InputNumber = 1;
            Console.Write("1+2+3+4....+??   請輸入?? :");
            int end = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("請輸入 想跳過的數字：");
                InputNumber = Convert.ToInt32(Console.ReadLine());
            }
            while (InputNumber > end || InputNumber < 0);

            int total = 0;
            string result = "";
            string dot = "";

            for (int i = 1; i <= end; i++)
            {
                if (i == InputNumber)
                    continue;
                if (i < end)
                {
                    result = result + string.Format("{0} + ", i);
                }
                else
                    result = result + string.Format("{0}  = ", i);

                total += i;
            }
            Console.WriteLine(result + total);
        }
    }
}