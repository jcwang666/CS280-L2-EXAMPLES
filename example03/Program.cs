using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql = "select * from table where id > 1000";

            string xml =
                @"<Pokemon>
                    <NatioNO>#001</NationalNo>
                     <Name>Bulbsaur</Name>
                  </Pokeman>";
            // string json =
            //     @"Pokeman={}
            //         "

            Console.WriteLine(sql);
            Console.WriteLine(xml);
            int? someInteger = null;
            Console.WriteLine(someInteger);
        }
    }
}