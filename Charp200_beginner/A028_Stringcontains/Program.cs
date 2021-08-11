using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A028_Stringcontains
{
    class Program
    {
        static void Main(string[] args)
        {
            // 28. 문자열 검색

            // 문자열 검색 메서드
            // 1. Contains() 메서드 : 문자열에 특정 문자열이 포함되어있는지를 체크, 포함되면 True, 아니면 False 반환
            // 2. IndexOf() 메서드 : 문자열에서 특정 문자 또는 문자열이 나타나는 인덱스 리턴(0 부터 시작, 없으면 -1 리턴)
            // 3. Comparison() : 대소문자를 비교하지 않는 비교
            // 4. String.StartsWith()와 StringEndsWith() 메서드 : 문자열이 특정 문자열로 시작 / 끝나는지 알려줍니다.

            string s1 = "mouse, cow, tiger, rabbit, dragon";
            //string s2 = "Cow";   
             string s2 = "cow";
            bool b = s1.Contains(s2);              // s1에 s2가 포함되어있는지 검사
            Console.WriteLine("'{0}' is in the string '{1}':{2}", s2, s1, b);

            // s2가 전부 소문자인 cow일때 => b가 true 일때
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                {
                    Console.WriteLine("'{0} begins at index {1}", s2, index);
                }
            }
           
            if(s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)  // CurrentCultureIgnoreCase를 사용하면 대소문자를 구별하지않음
            {
                Console.WriteLine("'{0}' is in the string '{1}'", s2, s1);
            }
        }
    }
}
