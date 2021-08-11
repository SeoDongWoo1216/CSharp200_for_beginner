using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace A031_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 31. String과 StringBuilder의 차이점
            // string 객체의 값은 한번 만들면 변경할 수 없다.
            // StringBuilder는 변경할 수 있다.

            // 따라서 string 객체가 자주 변경되는 경우 stringBuilder를 사용하는 것이 좋다.
            // StringBuilder는 문자열을 추가, 제거, 수정하는 메소드를 제공한다.

            StringBuilder sb = new StringBuilder("this is a StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Clear();  // StringBuilder 객체의 모든 문자를 없애줌(클리어)
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Append("This is a new string.");  // StringBuilder 객체 끝에 문자열을 추가해줌
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz ", 2);  // 특정한 위치에 저장한 문자열을 삽입해야함
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Remove(5, 4);  // 특정 위치에 있는 문자열을 삭제
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Replace("xyz", "abc");  // StringBuilder 객체에서 문자 혹은 substring을 다른 문자 혹은 substring으로 대체해줌.
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            // Stopwatch 를 사용해보자. (using System.Diagnostics; 라이브러리에 선언해줘야함)
            Stopwatch time = new Stopwatch();  // stopwatch 객체 선언
            string test = string.Empty;        
            time.Start();
            for(int i = 0; i < 100000; i++)   // start와 stop 사이의 시간을 측정해줌
            {
                test += i;
            }
            time.Stop();
            Console.WriteLine("String : " + time.ElapsedMilliseconds + " ms");

            StringBuilder test1 = new StringBuilder();
            time.Reset();    
            time.Start();
            for(int i = 0; i < 100000; i++)  // 위와 똑같이 10만번 반복하면서 test1 뒤에 숫자를 문자열로 추가하면서 시간 측정
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("StringBuilder : " + time.ElapsedMilliseconds + " ms");


            // string은 수정하는데 약 17초가 걸리지만,
            // stringBuilder는 약 12밀리초 밖에 걸리지않기때문에
            // 빈번한 변경을 할 경우에는 stringBuilder 를 사용하는 것이 훨씬 효율적인 것을 알 수 있다.
        }
    }
}
