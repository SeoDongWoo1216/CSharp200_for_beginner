using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A008_ConsoleWriteMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. 콘솔라이트라인 메서드로 여러개 값을 출력

            Console.WriteLine($"10 이하의 소수 : {2}, {3}, {5}, {7}");

            string primes;
            primes = String.Format("10이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7); 
            // Format 메서드를 통해 Console.WriteLine(); 처럼 문자열을 만들 수 있다.
            // Format은 데이터들을 어떤 형태로 출력할지 지정해줄 수 있다.
            Console.WriteLine(primes);
            
        }
    }
}
