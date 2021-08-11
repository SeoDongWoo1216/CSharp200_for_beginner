using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A027_StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            // 27. 문자열을 연결하는 4가지 방법
            // 방법 1. '+' 연산자 사용
            // 방법 2. 문자열 보간 ("" 앞에 $를 붙여서 $"" 를 사용하기)
            // 방법 3. string.Format() 
            // 방법 4. string.Concat() 과 string.Join() 

            string userName = "biking";
            string date = DateTime.Today.ToShortDateString();

            // 방법 1
            string strPlus = "Hello " + userName + ". Today is " + date + ".";  
            Console.WriteLine(strPlus);

            // 방법 2
            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat);

            // 방법 3
            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation);

            // 방법 4  // 
            string strConcat = String.Concat("Hello ", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = String.Join(", ", animals);
            Console.WriteLine(s);
        }
    }
}
