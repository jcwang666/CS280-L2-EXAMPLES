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
            Console.WriteLine("aAAAAAAAa");
            Console.Write("使用者名稱:");
            string userName = Console.ReadLine();
            Console.Write("請輸入密碼");
            string userPassword = Console.ReadLine();
            Console.WriteLine("{0} 您好，登入成功 ,{1}", userName, userPassword);

            Console.WriteLine("enter number1");
            int number1 = 3;
            Console.WriteLine("enter number2");
            int number2 = 5;

            int sum = number1 + number2;
            Console.WriteLine("The Sum = {0}", sum);
        }
    }
}