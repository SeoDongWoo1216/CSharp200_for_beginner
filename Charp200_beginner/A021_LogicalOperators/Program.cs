using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A021_LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 21. 논리연산자
            // &&, ||, ^, ! 4가지이며 각각 AND, OR, XOR, NOT 을 수행한다.
            // !를 빼고 전부다 이항연산자, !는 단항연산자.

            bool result;
            int first = 10;
            int second = 20;

            result = (first == second) || (first > 5);
            Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);

            result = (first == second) && (first > 5);
            Console.WriteLine("{0} && {1} : {2}", first == second, first > 5, result);

            result = true ^ false;
            Console.WriteLine("{0} ^ {1} : {2}", true, false, result);

            result = !(first > second);
            Console.WriteLine("!{0} : {1}", first > second, result);


        }
    }
}
