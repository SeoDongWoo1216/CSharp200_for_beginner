using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A023_ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 23. 조건연산자

            // 삼항연산자
            // 조건문 : 1 : 2     // 조건문이 참이면 1실행, 거짓이면 2실행

            int input = Convert.ToInt32(Console.ReadLine());

            string result = (input > 0) ? "양수입니다" : "음수입니다";
            Console.WriteLine("{0}는 {1}", input, result);
            Console.WriteLine("{0}는 {1}", input, (input % 2 == 0) ? "짝수입니다" : "홀수입니다");

            for(int i = 1; i <=50; i++)
            {
                Console.Write("{0,3}{1}", i, i % 10 != 0 ? "" : "\n");  
                // 10의 배수면 공백, 아니면 엔터처리
                // 따라서 1~10 까지 출력하고 엔터, 11~20까지 출력하고 엔터
            }
        }
    }
}
