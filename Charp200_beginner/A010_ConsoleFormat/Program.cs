using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A010_ConsoleFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. 형식지정자를 사용한 콘솔라이트라인 메서드

            Console.Clear();

            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(                        // 이름 : 정밀도 지정자
                "(C) Currency . . . . .  {0:C}\n" +   // 통화 : 십진자릿수
                "(D) Decimal . . . . . . {0:D}\n" +   // 십진수(정수) : 최소 자릿수
                "(E) Scientific . . . . .{1:E}\n" +   // 지수 : 소수 자릿수
                "(F) Fixed point . . . . {1:F}\n" +   // 고정자릿수 : 소수 자릿수
                "(G) General . . . . . . {0:G}\n" +   // 일반 : 유효자릿수
                "(N) Number . . . . . . .{0:N}\n" +   // ★천단위 구분 기호 : 소수 자릿수★
                "(P) Percent . . . . . . {1:P}\n" +   // 퍼센트 : 소수 자릿수
                "(R) Round-trip . . . . .{1:R}\n" +   // 라운드트립 : 무시됨
                "(H) Hexadecimal . . . . {0:X}\n",    // 16진수 : 자릿수
                -12345678, -1234.5678f);

            Console.WriteLine();
            Console.WriteLine();

            decimal value = 123456.789m;
            Console.WriteLine("잔액은 {0:C2}원 입니다.", value); // value값을 통화 형식으로 소숫점 아래 두 자리로 출력
            Console.WriteLine("잔액은 {0, 20:C2}원 입니다.", value); // 20:C2로 20자리를 차지하고 통화 형식으로 소숫점 아래 두자리로 출력
        }
    }
}