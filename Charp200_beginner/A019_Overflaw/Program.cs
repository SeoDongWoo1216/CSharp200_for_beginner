using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A019_Overflaw
{
    class Program
    {
        static void Main(string[] args)
        {
            // 19. 오버플로 예외처리
            // 오버플로 : 표현할 수 있는 최대값을 넘었을때 발생
            // int를 예로들면 값이  2,147,483,647 를 넘어가면 오버플로가 발생하여 프로그램이 뻗음

            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue;  // x에 int의 최대값을 저장
            int y = 0;

            checked
            {
                try
                {
                    y = x + 10;  // int의 최대값에 10을 더해줌 => 오버플로 발생
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}
