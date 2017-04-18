using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int? FirstNum = null;
            int? SecNum = null;
            try
            {
                Console.Write("請輸入第一個號碼:");
                FirstNum = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("第一個號碼錯誤:");
                return;
            }

            try
            {
                Console.Write("請輸入第二個號碼:");
                SecNum = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("第二個號碼錯誤:");
                return;
            }

            Console.WriteLine(FirstNum + SecNum);
        }
    }
}