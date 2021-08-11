using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A011_FormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. 형식 지정자를 사용하는 string.Format()과 ToString()

            // 표준 형식 지정자는 10에서 봤던 N, D, C, F, E 등으로 정밀도를 표현할 수 있다.
            // 커스텀 형식 지정자로는
            /*
             # : Digit placehloder(0이 앞에 붙지 않음)
             0 : Zero placeholder(0이 앞에 붙음)
             . : 소숫점(Decimal point)
             , : 천자리(Thousands operator)
             ; : 섹션 구분 기호(Section separator)  // 숫자를 표시할때 음수, 양수, 0 값을 ;로 구분하여 다른 포맷으로 출력
             */

            // 표준 형식 지정자
            Console.WriteLine("------표준형식 지정자------");
            Console.WriteLine("{0:N2}", 1234.5678);   // 1,234.57
            Console.WriteLine("{0:D8}", 1234);        // 00001234
            Console.WriteLine("{0:F3}", 1234.56);     // 1234.560
            Console.WriteLine("{0,8}", 1234);         // ____1234
            Console.WriteLine("{0,-8}", 1234);        // 1234____
            Console.WriteLine();


            // 표준 형식 지정자를 Format으로 사용
            Console.WriteLine("------표준 형식 지정자를 Format으로 사용------");
            
            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s);

            s = string.Format("{0:D8}", 1234);
            Console.WriteLine(s);

            s = string.Format("{0:F3}", 1234.56);
            Console.WriteLine(s);
            Console.WriteLine();


            // 표준 형식 지정자를 문자열로 변환하는 ToString(); 에 사용
            Console.WriteLine("------표준 형식 지정자를 문자열로 변환하는 ToString(); 에 사용------");
            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));
            Console.WriteLine();


            // 커스텀 형식 지정자 사용
            Console.WriteLine("------커스텀 형식 지정자 사용------");
            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:0,0.00}", 1234.5678);
            Console.WriteLine("{0:#,#.##}", 1234.5678);
            Console.WriteLine("{0:000000.00}", 1234.5678);
            Console.WriteLine();


            // 섹션 구분 기호 사용
            Console.WriteLine("------섹션 구분 기호 사용------");
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.567);  // 음수를 (1,234.57) 로 출력
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0);

        }
    }
}
