using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A014_StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14. 문자열과 숫자의 변환
            // Console.ReadLine()은 string으로 받는데 만약 이 변수로 계산하고싶다고하면 숫자로 바꿔줘야한다.
            // 따라서 숫자형식.Parse나 TryParse 메서드를 사용하거나 
            // Convert 클래스의 메서드를 사용하면된다.

            string input;
            int value;

            // int로 받은 숫자를 문자열로 변환
            Console.Write("1. int로 변환할 문자열을 입력하세요 : ");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);  // input을 정수 value로 변환 (이때 변환이 잘되면 true, 안되면 false가 result에 저장됨)

            if (!result)
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input);
            else
                Console.WriteLine("int '{0}'으로 변환되었습니다.\n", value);


            // double을 문자열로 변환
            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();

            try
            {
                double m = Double.Parse(input);          // 입력받은 input(string)을 double형으로 변환
                // double m = Convert.ToDouble(input);   // Double.Parse와 같은 의미
                Console.WriteLine("double '{0}'으로 변환되었습니다.\n", m);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
