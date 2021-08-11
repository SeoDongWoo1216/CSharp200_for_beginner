using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A007_ConsoleWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. 콘솔라이트라인 메서드

            bool b = true;
            char c = 'A';
            decimal d = 1.234m;
            double e = 1.23456789;
            float f = 1.23456789f;  // 소숫점 감당안되서 짤려서 출력됨
            int i = 1234;
            string s = "Hello";

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
