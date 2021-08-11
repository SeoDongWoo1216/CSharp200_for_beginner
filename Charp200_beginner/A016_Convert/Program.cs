using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A016_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            // 16. Convert 클래스와 2, 8, 16 진수 출력
            // Console.ReadLine()으로 받은 string을 Convert를 통해 숫자로 변환해보자.
            // ToInt32() : int, ToSingle() : float, ToDouble() : double 등이 있음.
            // string을 숫자뿐만아니라 ToString(), ToByte(), ToBoolean(), ToChar(), ToDateTime() 등이 있다.

            int x, y;

            Console.Write("첫 번재 숫자를 입력하세요 : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요 : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            // 2, 8, 10, 16진수로 출력
            short value = short.MaxValue;  // Int16.MaxValue
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");

            // 2진수
            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);

            // 8진수
            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);

            // 10진수
            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);

            // 16진수
            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1, 2}진수 = {2, 16}", i, baseNum, s);

        }
    }
}
