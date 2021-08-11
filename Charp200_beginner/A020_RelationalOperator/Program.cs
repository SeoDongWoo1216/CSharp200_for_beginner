using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A020_RelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20. 관계연산자 : 두 개의 피연산자 사이의 크기 관계를 체크할 때 사용
            // ==, >, <, <=, >=, != 

            bool result;
            int first = 10;
            int second = 20;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first > second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first < second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first >= second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first <= second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first != second);  // 두 값이 다른지 비교 => 10, 20 이니까 True 출력
            Console.WriteLine("{0} == {1} : {2}", first, second, result);
        }
    }
}
