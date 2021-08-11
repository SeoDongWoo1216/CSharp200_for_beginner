using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A034_ValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34. 값 형식(value type)과 참조 형식(reference type), ref 키워드

            // 값 형식은 변수가 실제 데이터 값을 저장하는 형식
            // 참조 형식은 변수가 값이 저장되어있는 곳의 위치를 저장하는 형식

            // string이나 배열은 참조형식

            string s = "before passing";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
        }

        // 메서드 오버로딩
        private static void Test(string s)
        {
            s = "after passing";
        }

        private static void Test(ref string s)
        {
            s = "after passing";
        }


    }
}
