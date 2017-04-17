using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    internal class Program
    {
        /// <summary>
        /// ｝
        /// </summary>
        /// <param name="args"></param>
        //private static void Main(string[] args)
        //{
        //    string str = "100.3";
        //    float number = 0.0f;
        //    float.TryParse(str, out number);
        //}
        Console.Write("使用者名稱:");
private string userName = Console.ReadLine();
        Console.Write("請輸入密碼");
private string userPassword = Console.ReadLine();
        Console.WriteLine("{0} 您好，登入成功", userName);
    }
}