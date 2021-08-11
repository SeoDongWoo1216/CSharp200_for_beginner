using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A033_ConstAndReadonly
{
    class ConstEX
    {
        public const int number = 3;
    }

    class ReadonlyEx
    {
        public readonly int number = 10;
        public ReadonlyEx()   // 생성자 오버로딩
        {
            number = 20;
        }
        public ReadonlyEx(int n)
        {
            number = n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 33. 상수 const와 readonly

            // const를 통해 변하지 않는 상수를 만들 수 있다.
            // readonly는 변수를 선언하는 시점과 생성자 메소드에서만 값을 변경할 수 있는 읽기 전용 키워드이다.

            /* 두 키워드의 차이점
             const : 선언될때 값이 할당, 컴파일 시에 값이 결정
            readonly : 실행될때 또는 객체가 생성자에 의해 초기화할때 값이 할당, 런타임 시에 값이 결정
            */

            Console.WriteLine(ConstEX.number);  // const 사용

            ReadonlyEx inst1 = new ReadonlyEx();  // readonly 사용
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100); // readonly 사용
            Console.WriteLine(inst2.number);
        }
    }
}
