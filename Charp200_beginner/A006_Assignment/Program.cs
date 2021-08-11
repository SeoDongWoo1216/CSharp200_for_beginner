using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A006_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. 대입연산자와 대입문

            int i;
            double x;

            i = 5;
            x = 3.141592;
            Console.WriteLine("i = " + i + ", x = " + x);

            x = i;        // 암시적 형변환(int보다 double이 크므로 굳이 형변환 써줄필요없음)
            i = (int)x;   // int에 double형을 적기때문에 캐스트 필요

            Console.WriteLine("i = " + i + ", x = " + x);
        }
    }
}
