using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A003_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. 콘솔에서 읽고 쓰기
            // Read(); : 한 글자 읽기
            // ReadLine(); : 한 줄 읽기
            Console.Write("Hello");
            Console.WriteLine(" World");
            Console.Write("이름을 입력하세요 : ");

            string name = Console.ReadLine();  // 이름 입력 받기
            Console.WriteLine($"안녕하세요 {name} 님!");
            
        }
    }
}
