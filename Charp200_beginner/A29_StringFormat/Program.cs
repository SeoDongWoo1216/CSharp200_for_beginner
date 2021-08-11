using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A29_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            // 29. String.Format의 날짜와 시간 형식 지정

            // string.Format은 지정된 형식에 따라 객체, 변수, 수식의 값을 문자열로 변환하여 다른 문자열에 삽입한다.
            // 포맷 문자열에 {0}, {1}, ... 와 같은 인덱스를 사용하여 표현하려는 객체, 변수, 수식(포맷아이템)을 나타낸다.
            // 포맷 문자열 뒤에 나오는 파라미터는 0부터 순서대로 번호가 부여된다.

            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            // X : 16진수형, E : 지수형, N : 구분자 가 있는 숫자형으로 변환하여 max에 저장

            Console.WriteLine(max);


            Decimal exchangeRate = 1129.20m;


            string s = String.Format("현재 원달러 환율은 {0}입니다.", exchangeRate);
            Console.WriteLine(s);


            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate);
            // C2를 통해 exchangeRate값을 통화 형식으로 원을 표시하는 '원'표시와 3자리마다 콤마를 넣어줌
            Console.WriteLine(s);


            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t}입니다.", DateTime.Now);
            // DateTime.Now 로 현재 날짜 출력
            Console.WriteLine(s);


            TimeSpan duration = new TimeSpan(1, 12, 23, 62);   // duration은 TimeSpan 구조체 변수로써 초기값을 1, 12, 23, 62로 세팅해줌
            string output = String.Format("소요 시간 : {0:c}", duration);
            Console.WriteLine(output);
        }
    }
}
