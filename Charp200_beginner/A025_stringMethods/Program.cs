using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 25. string 클래스
            // string 클래스의 메서드를 사용해보자.

            string s = "Hello, World!";
            string t;

            Console.WriteLine(s.Length);            // s의 길이 구하기
            Console.WriteLine(s[8]);                // s의 8번째 글자 출력(o)
            Console.WriteLine(s.Insert(8, "C# "));  // 8번째에 "C# " 삽입
            Console.WriteLine(s.PadLeft(20, '.'));  // 왼쪽부터 특정 문자를넣어서 글자수를 20으로 맞춤
            Console.WriteLine(s.PadRight(20, '.')); // 오른쪽부터 특정 문자를 넣어서 글자수를 20으로 맞춤
            Console.WriteLine(s.Remove(6));         // 6번째 인덱스부터 끝까지 지움
            Console.WriteLine(s.Remove(6, 7));      // 6번째 인덱스부터 7개의 문자를 지움
            Console.WriteLine(s.Replace('l', 'm')); // l이라는 문자를 m으로 바꿔줌
            Console.WriteLine(s.ToLower());         // s의 문자를 전부 소문자로 출력
            Console.WriteLine(s.ToUpper());         // s의 문자를 전부 대문자로 출력
            Console.WriteLine('/' + s.Trim() + '/');       // 앞뒤 공백문자를 없애줌
            Console.WriteLine('/' + s.TrimStart() + '/');  // 앞쪽의 공백문자를 없애줌
            Console.WriteLine('/' + s.TrimEnd() + '/');    // 뒤쪽의 공백문자를 없애줌

            string[] a = s.Split('.');        // Split을 이용해 문자열을 콤마로 구분하여 스트링 배열로 만들어줌
            foreach (var i in a) 
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 4);   // string의 일부분을 문자 배열로 저장.
                                              // 따라서 s의 8번째 인덱스로부터 dstination 배열의 0번째 인덱스로 6개의 문자 "World!"를 복사해줌
            Console.WriteLine(destination);

            Console.WriteLine('/' + s.Substring(8) + '/');     // Substring을 통해 8번째 인덱스로부터 맨 뒤까지의 문자열을 리턴
            Console.WriteLine('/' + s.Substring(8, 5) + '/');  // 8번째부터 5번째까지의 문자열을 리턴해줌

            Console.WriteLine(s.Contains("ll"));     // s에 ll이라는 문자열이있으면 true 또는 false 반환
            Console.WriteLine(s.IndexOf('o'));       // s에서 처음 나오는 'o'의 위치를 리턴
            Console.WriteLine(s.LastIndexOf('0'));   // s에서 맨 마지막으로 나오는 o의 위치를 리턴
            Console.WriteLine(s.CompareTo("abc"));   // s와 "abc"를 사전식으로 비교하여 s가 "abc"보다 앞에 나오면 마이너스, 같으면 0, s가 "abc"보다 뒤에나오면 플러스값을 리턴
                                                     // 따라서 "Hello, World!"는 빈칸으로 시작하므로 "abc"보다 앞에 나오기 때문에 -1이 리턴된다.

            Console.WriteLine(String.Concat("Hi~"), s);   // Concat는 정적 메서드로써, concat안의 두 문자열을 합쳐줌
            Console.WriteLine(String.Compare("abc", s));  // compare는 정적 메서드로써, 두개의 문자열을 비교해서 "abc"의 가 'a' 빈칸보다 뒤에 나오므로 +1이 출력됨.
            Console.WriteLine(t = String.Copy(s));        // Copy는 정적 메서드로써, t에 s값을 저장한다.(복사해주는 개념)

            String[] val = { "apple", "orange", "grape", "pear" };  // 문자열 배열 val을 선언하고 4단어로 초기화
            string result = String.Join(", ", val);                 // ','으로 연결해서 result에 저장
            Console.WriteLine(result);


        }
    }
}
