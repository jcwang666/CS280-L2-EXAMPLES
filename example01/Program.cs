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

            float floatPI = 3.141592653589793238f;
            double doublePI = 3.141592653589793238;
            Console.WriteLine("Float PI is: {0}", floatPI);
            Console.WriteLine("Double PI is: {0}", doublePI);
        }
    }
}