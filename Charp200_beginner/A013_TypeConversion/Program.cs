using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A013_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13. 캐스팅과 자료형 변환
            // 하나의 자료형을 다른 자료형으로 바꾸는 것을 형변환

            // 암시적 형변환 : float -> double처럼 작은 자료형을 더 큰 자료형으로 변환
            // 명시적 형변환 : double -> int처럼 큰 자료형을 작은 자료형으로 변환
            //                이때 큰 자료형에 작은 자료형을 ()안에 붙여줘야함.
            //                예시) double x; int a = (int) x;


            int num = 2147483647;
            long bigNum = num;  // int에서 long으로 변환(암시적 형변환)
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x;         // double에서 int로명시적 형변환
            Console.WriteLine(a);
        }
    }
}
