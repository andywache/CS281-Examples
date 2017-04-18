using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long ms = 0;
            Console.WriteLine("請輸入毫秒：");
            try
            {
                ms = long.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("資料輸入錯誤!!");
                return;
            }

            long sec = ms / 1000 % 60;        //計算秒數
            long min = ms / 1000 / 60 % 60;         //計算分鐘
            long hr = ms / 1000 / 60 / 60;          //計算小時

            Console.Write("轉換後：" + ms + "毫秒 = " + hr + "小時 ," + min + "分鐘 ," + sec + "秒鐘\n");
        }
    }
}