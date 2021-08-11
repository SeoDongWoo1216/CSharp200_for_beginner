using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A026_SplitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // 26. string.split() 메서드
            // split() 을 통해 ()값에따라 문자열을 쪼개주는 기능을 한다.

            Console.Write("더할 숫자 입력 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach (var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}
