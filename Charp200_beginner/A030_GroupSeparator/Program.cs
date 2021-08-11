using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A030_GroupSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 30. 그룹 분리자를 넣는 방법
            
            // 숫자 정수부를 표시할때 세자리마다 콤마(,)를 넣는 것이 편리한데 이 콤마를 그룹 분리자라고 한다.
            // 표준 형식 지정자 중에 N이 그룹 분리자를 표시해준다.
            // N 형식 지정자는 디폴트로 소수점 아래 두 자리를 표시해주고, 소숫점 아래 자릿수를 지정할 때는 N 뒤에 숫자로 표시한다. 출력은 반올림된다.

            while(true)  // -1를 누를때까지 무한 반복하는 구문
            {
                Console.Write("표시할 숫자(종료:-1) : ");
                string s = Console.ReadLine();
                double v = double.Parse(s);
                if (v == -1)
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s)); // NumberWithGroupSeparator라는 메서드 호출
            }
        }

        // 숫자를 그룹 분리자가 포함된 문자열로 바꿔서 리턴해주는 메서드
        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0;
            double v = Double.Parse(s);

            if (s.Contains("."))  // s에 '.'이 있는지 검사
            {
                pos = s.Length - s.IndexOf('.');    // 소숫점이있으면 문자열의 길이에서 소수점이 있는 인덱스를 뺀 값을 pos에 저장
                string formatStr = "{0:N" + (pos - 1) + "}";  // 소수점 아래 자릿수를 {0:N2}로 출력
                s = string.Format(formatStr, v);
            }
            else   // 소수점이 없으면 {0:N0} 포맷으로 출력
                s = string.Format("{0:N0}", v);
            return s;
        }
    }
}
