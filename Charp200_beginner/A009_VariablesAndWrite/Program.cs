using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A009_VariablesAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. 두 변수를 출력하는 방법

            int v1 = 100;
            double v2 = 1.234;

            // Console.WriteLine(v1, v2);  // 이건 에러발생

            Console.WriteLine(v1.ToString() + ", " + v2.ToString());
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");
        }
    }
}
