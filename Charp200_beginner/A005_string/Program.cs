using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A005_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. 문자와 문자열

            string a = "hello";
            string b = "h";

            b = b + "ello";   // b에 hello 저장
            Console.WriteLine(a == b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x; // 문자 '!'와 문자열 " "(공백) 을 더한것을 c에 저장
            Console.WriteLine("c = " + c);

        }
    }
}
