using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A032_Enum
{
    class Program
    { 
        enum Size {Short, Tall, Grande, Venti};
        static int[] price = { 3300, 3800, 4300, 4800 };
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8};
        enum Coffee { Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800};

        static void Main(string[] args)
        {
            // 32. 열거형 Enum

            // 열거형은 서로 관련있는 상수들의 집합을 정의한 것이다.
            // 이때 숫자에 특정한 명칭을 붙여주어 의미를 쉽게 이해할 수 있는 용도로 사용된다.
            // 예를들어 사과, 바나나, 오렌지  세 가지의 과일을 0, 1, 2라는 숫자를 부여해서 사용할 수 있다.


            // 열거형 Size의 각 요소에 가격을 price 배열에서 가져와서 출력
            Console.WriteLine("커피 가격표");
            for(int i = 0; i < 4; i++)
            {
                if (i == (int)Size.Short)
                    Console.WriteLine("{0,10} : {1:C}", Size.Short, price[i]);
                else if (i == (int)Size.Tall)
                    Console.WriteLine("{0,10} : {1:C}", Size.Tall, price[i]);
                else if (i == (int)Size.Grande)
                    Console.WriteLine("{0,10} : {1:C}", Size.Grande, price[i]);
                else if (i == (int)Size.Venti)
                    Console.WriteLine("{0,10} : {1:C}", Size.Venti, price[i]);
            }

            // Enum.GetValues(typeof(Szie))를 foreach문에 사용하여 열거형의 각 요소를 반복문으로 사용할 수 있음
            Console.WriteLine("\n커피 가격표(Enum iteration)");
            foreach (var size in Enum.GetValues(typeof(Size)))
            {
                Console.WriteLine("{0,10} : {1:C}", size, price[(int)size]);
            }

            // 반복문에서 Colors 열거형의 각 요소 이름과 값 출력
            Console.WriteLine("\nColors Enum iteration");
            foreach (var color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine("{0,10} : {1}", color, Convert.ToInt32(color));
            }

            // coffe 열거형 각 요소 이름과 값 출력 => 이럴때는 price[] 배열을 사용할 필요 없음
            Console.WriteLine("\n커피 가격표(Enum iteration with value)");
            foreach (var coffee in Enum.GetValues(typeof(Coffee)))
            {
                Console.WriteLine("{0,10} : {1:C}", coffee, Convert.ToInt32(coffee));
            }

        }
    }
}
