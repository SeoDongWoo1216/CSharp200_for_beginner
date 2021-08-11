using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A024_CompoundAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 24. 증가연산자, 감소연산자, 대입연산자의 압축
            // x = x + 3; 으로 쓰던걸 x += 3; 으로 쓸수있다.(+, -, *, /, %)

            int x = 32;

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 8);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);

            Console.WriteLine(x++);  // x를 출력하고 ++해줌
            Console.WriteLine(--x);  // x에 1을빼고 출력
        }
    }
}
