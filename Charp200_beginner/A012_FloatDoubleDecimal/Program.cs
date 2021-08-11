using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A012_FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12. 실수를 표현하는 데이터타입
            // float < double < decimal
            //  7자리 < 16자리 < 29자리    decimal로 갈수록 정밀한 숫자 표현 가능

            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            // 각 변수에 저장된 값 출력
            Console.WriteLine("float : {0}", flt);
            Console.WriteLine("double : {0}", dbl);
            Console.WriteLine("decimal : {0}", dcm);
            Console.WriteLine();

            // sizeof(); 를 통해 각 데이터타입의 크기를 출력
            Console.WriteLine("float : {0}", sizeof(float));
            Console.WriteLine("double : {0}", sizeof(double));
            Console.WriteLine("decimal : {0}", sizeof(decimal));
            Console.WriteLine();

            // MinValue, MaxValue를 통해 각 데이터타입의 최소, 최대값 출력
            Console.WriteLine("float : {0}~{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine();
        }
    }
}
