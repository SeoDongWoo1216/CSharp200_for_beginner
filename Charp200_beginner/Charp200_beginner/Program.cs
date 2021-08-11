using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp200_beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. 변수 선언 및 자료형*/
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();  // name에 입력받은 문자열을 저장

            Console.Write("나이를 입력하세요 : ");
            int age = int.Parse(Console.ReadLine());  // age에 입력받은 숫자값을 저장(문자열을 정수로 바꿈)

            Console.Write("키를 입력하세요(cm) : ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine($"안녕하세요 {name} 님!");
            Console.WriteLine($"나이는 {age} 세,");
            Console.WriteLine($"키는 {height} 이시군요!");
        }
    }
}
