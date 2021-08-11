using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A022_BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 22. 비트연산자
            // ~, &, |, ^, <<, >>
            // NOT, AND, OR, XOR, Left Shift, Right Shift

            int x = 14;
            int y = 11;
            int result;

            result = x | y;
            Console.WriteLine("{0} | {1} = {2}", x, y, result);

            result = x & y;
            Console.WriteLine("{0} & {1} = {2}", x, y, result);

            result = x ^ y;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, result);

            result = ~x;
            Console.WriteLine("~{0} = {1}", x, result); // x의 보수를 계산 (14의 0을 1로, 1을 0으로 바꾸면 -15가 출력)

            result = x << 2;
            Console.WriteLine("{0} << 2 = {1}", x, result); // 왼쪽으로 2비트 시프트 => 4를 곱하는 결과

            result = y >> 1;
            Console.WriteLine("{0} >> 1 = {1}", y, result); // 오른쪽으로 1비트 시프트 => 2를 나누는 결과


        }
    }
}
