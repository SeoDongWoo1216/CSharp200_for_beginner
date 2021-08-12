using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace Charp200_beginner_WPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////

        private void 삼십오_Click(object sender, RoutedEventArgs e)
        {
            // 35. 배열과 객체를 메소드 매개변수로 전달
            // 배열은 참조형이고 배열 이름은 그 배열이 저장된 곳의 참조이다.
            // 따라서 메소드를 호출할대 배열의 이름을 매개변수로 전달하면 배열의 참조가 전달된다.
            // 클래스의 객체도 참조형이므로 같이 호출된 메소드 안에서 내용을 바꾸면 호출한 곳에서도 바뀌게 된다.

            Console.WriteLine("-------- 35.배열과 객체를 메소드 매개변수로 전달 --------");

            int[] arr35 = { 10, 20, 30 };
            Console.WriteLine("Main() before: arr[0] = {0}", arr35[0]);
            Change(arr35);
            Console.WriteLine("Main() after: arr[0] = {0}", arr35[0]);

            _35_Class s35 = new _35_Class();
            s35.name = "Alpha";
            Console.WriteLine("Main() before : " + s35.name);
            Change(s35);
            Console.WriteLine("Main() after : " + s35.name);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
        }

        private void Change(int[] arr)
        {
            arr[0] = -10;
        }

        private void Change(_35_Class s1)
        {
            s1.name = "Beta";
        }


        //////////////////////////////////////////////////////////////////


        private void 삼십육_Click(object sender, RoutedEventArgs e)
        {
            // ★ 36. NULL 조건 연산자(?) ★
            // NULL : 어떤 객체도 참조하지 않는 참조형 변수
            // 참조형 변수의 디폴트 값이 NULL이다. (값형은 null일 수 없다)
            // 따라서 참조형 변수의 속성을 사용하려고하면 그 변수는 null일 수 없다.(예외발생)
            Console.WriteLine("-------- 36. NULL 조건 연산자(?) --------");
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.(그냥 엔터치면 종료)");
            do
            {
                LongNameAnimal(animal);
                Console.Write("동물 이름 : ");
            } while ((animal = Console.ReadLine()) != "");

            Console.WriteLine("종료합니다.");
            Console.WriteLine("-----------------------------------------");

        }

        private void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4)  // ★ NULL 조건 연산자 ★
            {
                Console.WriteLine(animal + " : " + animal.Length);
            }
        }


        //////////////////////////////////////////////////////////////////

        private void 삼십칠_Click(object sender, RoutedEventArgs e)
        {
            // 37. 변수의 초기화와 default

            Console.WriteLine("-------- 37. 변수의 초기화와 default --------");
            _37_Class _37_Class1 = new _37_Class();
            int a37 = default;
            string s37 = default;

            Console.WriteLine("a37 = " + a37);
            Console.WriteLine("s37 = " + s37);

            Console.WriteLine("E = " + default(_37_Class.E37));
            Console.WriteLine("E = " + (_37_Class.E37)0);

            MyList37<int> iList = new MyList37<int>();
            Console.WriteLine("iList : " + iList.GetLast());

            MyList37<string> sList = new MyList37<string>();
            Console.WriteLine("sList : " + sList.GetLast());
            Console.WriteLine("--------------------------------------------");
        }

        //////////////////////////////////////////////////////////////////

        private void 삼십구_Click(object sender, RoutedEventArgs e)
        {
            // 39. object 타입과 박싱, 언박싱

            int i39 = 123;
           
            object o39 = i39;  // i의 값을 박싱하여 o로 복사
            
            i39  = i39 + 10;  // i의 값을 바꿔줌, o는 바뀌지않음
            
            int j39 = (int)o39;  // o의 값을 언박싱하여 j로 복사

            // i의 값이 변해도 o에 저장된 값은 영향을 받지 않음.
            Console.WriteLine("The value-type value i = {0}", i39);
            Console.WriteLine("The value-type value j = {0}", j39);
            Console.WriteLine("The value-type value o = {0}", o39);

            object p39 = o39;
            o39 = 100;
            Console.WriteLine("The object-type value o39 = {0}", o39);
            Console.WriteLine("The object-type value p39 = {0}", p39);
        }

        //////////////////////////////////////////////////////////////////

        private void 사십_Click(object sender, RoutedEventArgs e)
        {
            // 40. if~else 조건문

            int year40 = int.Parse(Console.ReadLine());

            if(year40 % 4 == 0 && year40 % 100 != 0 || year40 % 400 == 0)
                Console.WriteLine("{0}는 윤년", year40);
            else
                Console.WriteLine("{0}는 평년", year40);

            if (DateTime.IsLeapYear(year40))      // IsLeapYear() 메서드를 통해 윤년, 평년을 계산해줌
                Console.WriteLine("{0}은 윤년", year40);
            else
                Console.WriteLine("{0}은 평년", year40);
            
        }

        //////////////////////////////////////////////////////////////////

        private void 사십일_Click(object sender, RoutedEventArgs e)
        {
            // 41. switch 문
            Console.Write("점수를 입력하세요: ");
            int score41 = int.Parse(Console.ReadLine());

            string grade41 = null;

            if (score41 >= 90)  grade41 = "A";
            else if (score41 >= 80)  grade41 = "B";
            else if (score41 >= 70)  grade41 = "C";
            else if (score41 >= 60)  grade41 = "D";
            else grade41 = "F";

            Console.WriteLine("학점은 {0}", grade41);

            switch (score41 / 10)
            {
                case 10:
                case 9:
                    grade41 = "A";
                    break;
                case 8:
                    grade41 = "B";
                    break;
                case 7:
                    grade41 = "C";
                    break;
                case 6:
                    grade41 = "D";
                    break;
                default:
                    grade41 = "F";
                    break;
            }
            Console.WriteLine("학점은 {0}", grade41);
        }

        //////////////////////////////////////////////////////////////////

        private void 사십삼_Click(object sender, RoutedEventArgs e)
        {
            // 43. 반복문(1~100 까지 더하고, 역수의 합)

            // 1. 1 ~ 100 까지 더하기
            int sum43_1 = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum43_1 += i;
            }
            Console.WriteLine("1~100 까지 숫자의 합은 {0}입니다.", sum43_1);

            // 2. 1 ~ 100까지 홀수의 합
            int sum43_2 = 0;
            for(int x = 1; x <= 100; x++)
            {
                if(x % 2 == 1)
                {
                    sum43_2 += x;
                }
            }
            Console.WriteLine("1 ~ 100까지 홀수 합은 {0}", sum43_2);

            // 3. (1 + 1) / (2 + 1) / (3 + ... + 1) / 100 구하기 
            double sum43_3 = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum43_3 += 1.0 / i;
            }
            Console.WriteLine("1 ~ 100까지 역수의 합은 {0}", sum43_3);

        }

        //////////////////////////////////////////////////////////////////

        private void 사십사_Click(object sender, RoutedEventArgs e)
        {
            // 44. 반복문으로 2진, 8진, 16진 출력
            Console.WriteLine("{0,5}, {1,8}, {2, 3}, {3, 4}", "10진수", "2진수", "8진수", "16진수");

            for(int i = 1; i <= 128; i++)
            {
                Console.WriteLine("{0,7}, {1,10}, {2,5}, {3,6}", i,
                    Convert.ToString(i, 2).PadLeft(8, '0'),
                    Convert.ToString(i, 8),
                    Convert.ToString(i, 16)
                    );
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 사십오_Click(object sender, RoutedEventArgs e)
        {
            // 45. 반복문으로 구구단 출력

            Console.Write("구구단의 출력할 단수를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 사십팔_Click(object sender, RoutedEventArgs e)
        {
            // 48. 팩토리얼 구하기

            Console.WriteLine("n! 을 계산합니다.");
            Console.Write("정수 n을 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("{0}! = {1}", n, fact);
            
        }


        //////////////////////////////////////////////////////////////////
        private void 사십구_Click(object sender, RoutedEventArgs e)
        {
            // 49. 소수 판단하기

            Console.Write("숫자를 입력하세요 : ");
            int num49 = int.Parse(Console.ReadLine());
            int index49;

            for(index49 = 2; index49 < num49; index49++)
            {
                if(num49 % index49 == 0)
                {
                    Console.WriteLine("{0}는 소수가 아닙니다.");
                    break;
                }
            }
            if(index49 == num49)
            {
                Console.WriteLine("{0}은 소수입니다.", num49);
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 오십_Click(object sender, RoutedEventArgs e)
        {
            // 50. 원주율의 계산
            bool sign50 = false;
            double pi50 = 0;

            for(int i = 1; i <= 10000; i += 2)  // 반복할수록 값이 더 정확해짐
            {
                if(sign50 == false)
                {
                    pi50 += 1.0 / i;
                    sign50 = true;
                }
                else
                {
                    pi50 -= 1.0 / i;
                    sign50 = false;
                }
                Console.WriteLine("i = {0}, PI = {1}", i, 4 * pi50);
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 오십일_Click(object sender, RoutedEventArgs e)
        {
            // 51. 무한루프와 break 문

            int sum51 = 0;
            int days51 = 1;
            int money51 = 1000;

            while(true)
            {
                sum51 += money51;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days51, money51, sum51);
                if (sum51 >= 1000000)
                    break;
                days51++;
                money51 *= 2;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days51, sum51);

            for(sum51 = 0, days51 = 1, money51 = 1000; ; days51++, money51 *= 2)
            {
                sum51 += money51;
                Console.WriteLine("{0,2}일차 : {1, 8:C}, sum = {2,11:C}", days51, money51, sum51);
                if (sum51 > 1000000)
                    break;
            }
            Console.WriteLine("{0}일차에 {1:###.###}원이 됩니다.", days51, sum51);
        }

        //////////////////////////////////////////////////////////////////

        private void 오십이_Click(object sender, RoutedEventArgs e)
        {
            // 52. 합계가 10000이 넘어가는 순간

            int sum52 = 0;
            for(int i = 1; ; i++)
            {
                sum52 += i;
                if(sum52 >= 10000)
                {
                    Console.WriteLine("1~{0}의 합 = {1}", i, sum52);
                    break;
                }
            }

            sum52 = 0;
            int index52 = 1;
            for(; sum52<10000; index52++)
            {
                sum52 += index52;
            }
            Console.WriteLine("1~{0}의 합 = {1}", index52 - 1, sum52);
        }

        //////////////////////////////////////////////////////////////////

        private void 오십삼_Click(object sender, RoutedEventArgs e)
        {
            // 53. 이중반복문으로 1~n까지의 팩토리얼과 합 구하기

            Console.Write("숫자를 입력하세요 : ");
            int n53 = int.Parse(Console.ReadLine());

            int sum53 = 0;
            for(int i = 1; i <= n53; i++)
            {
                int fact53 = 1;
                for(int j = 2; j <= i; j++)
                {
                    fact53 *= j;
                }
                sum53 += fact53;
                Console.WriteLine("{0,2}! = {1,10:#,#}", i, fact53);
            }
            Console.WriteLine("1! + 2! + ... + {0}! = {1:N0}\n", n53, sum53);

        }

        //////////////////////////////////////////////////////////////////

        private void 오십사_Click(object sender, RoutedEventArgs e)
        {
            // 54. 이중 루프를 이용하여 구구단 출력

            for(int y = 1; y <= 9; y++)
            {
                for(int x = 2; x <= 9; x++)
                {
                    Console.Write("{0} x {1} = {2,2}    ", x, y, x * y);
                }
                Console.WriteLine();
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 오십오_Click(object sender, RoutedEventArgs e)
        {
            // 55. 1000까지 소수 출력하고 이게 몇개 인지 출력

            int index55;
            int prime55 = 0;

            for (int i = 2; i < 1000; i++)
            {
                for(index55 = 2; index55 < 1000; index55++)
                {
                    if(i % index55 == 0)
                    {
                        break;
                    }
                }
                if(index55 == i) // i가 소수라면
                {
                    prime55++;
                    Console.Write("{0,5}{1}", i, prime55 % 15 == 0 ? "\n" : "");
                }
            }
            Console.WriteLine("\n2부터 1000사이 소수 개수 : {0}개", prime55);
            
        }

        //////////////////////////////////////////////////////////////////

        private void 오십육_Click(object sender, RoutedEventArgs e)
        {
            // 56. 이중 루프와 피라미드 출력

            // (1)
            // (1)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            // (2)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            // (3)
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            // (4)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            // (5)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            // (6)
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 오십칠_Click(object sender, RoutedEventArgs e)
        {
            // 57. 배열의 초기화와 배열 요소의 출력
            int[] a57 = { 1, 2, 3 };
            Console.Write("a[]: ");
            foreach (var value in a57)
                Console.Write(value + " ");

            int[] b57 = new int[] { 1, 2, 3 };
            Console.Write("\nb[]: ");
            for (int i = 0; i < 3; i++)
                Console.Write(b57 + " ");

            int[] c57 = new int[3] { 1, 2, 3 };
            Console.Write("\nc[]: ");
            for (int i = 0; i < c57.Length; i++)
                Console.Write(c57[i] + " ");

            int[] d = new int[3];
            d[0] = 1;
            d[1] = d[0] + 1;
            d[2] = d[1] + 1;
            Console.Write("\nd[]: ");
            foreach (int value in d)
                Console.Write(value + " ");
            Console.WriteLine();
        }

        //////////////////////////////////////////////////////////////////

        private void 오십팔_Click(object sender, RoutedEventArgs e)
        {
            // 58. 배열과 Array 클래스

            int[] a58 = { 5, 25, 75, 35, 15 };  // 배열 선언하고 초기화
            PrintArray(a58);

            int[] b58;
            b58 = (int[])a58.Clone();      // 배열 복사 방법1
            PrintArray(b58);

            int[] c58 = new int[10];
            Array.Copy(a58, 0, c58, 1, 3); // 배열 복사 방법2
            PrintArray(c58);

            a58.CopyTo(c58, 3);            // 배열 복사 방법3.
            PrintArray(c58);
            
            Array.Sort(a58);   // 오름 차순으로 정렬
            PrintArray(a58);

            Array.Reverse(a58); // 내림 차순으로 정렬
            PrintArray(a58);

            Array.Clear(a58, 0, a58.Length); // 배열을 초기화
            PrintArray(a58);
        }

        private void PrintArray(int[] a58)
        {
            foreach (var i in a58)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }

        //////////////////////////////////////////////////////////////////

        private void 오십구_Click(object sender, RoutedEventArgs e)
        {
            // 59. 다차원 배열

            Console.WriteLine("2차원 배열 : ArrA[2,3]");
            int[,] arrA59 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}", arrA59[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("가변 배열 : ArrB[2][3]");
            int[][] arrB59 = new int[2][];
            arrB59[0] = new int[] { 1, 2 };
            arrB59[1] = new int[] { 3, 4, 5 };

            for(int i = 0; i < 2; i++)
            {
                Console.Write("arrB[{0}] : ", i);
                for(int j = 0; j < arrB59[i].Length; j++)
                {
                    Console.Write("{0}  ", arrB59[i][j]);
                }
                Console.WriteLine();
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 육십오_Click(object sender, RoutedEventArgs e)
        {
            // 65. 클래스와 구조체

            DateStruct65 sDay65;
            sDay65.year = 2018;
            sDay65.month = 11;
            sDay65.day = 22;
            Console.WriteLine("sDays : {0}/{1}/{2}", sDay65.year, sDay65.month, sDay65.day);

            DateClass65 cDay65 = new DateClass65();
            cDay65.year = 2018;
            cDay65.month = 11;
            cDay65.day = 22;
            Console.WriteLine("cDays : {0}/{1}/{2}", cDay65.year, cDay65.month, cDay65.day);

            DateStruct65 sDay65_2 = new DateStruct65();
            Console.WriteLine("sDay2: {0}/{1}/{2}", sDay65_2.year, sDay65_2.month, sDay65_2.day);

            DateClass65 cDay65_2 = new DateClass65();
            Console.WriteLine("cDay2: {0}/{1}/{2}", cDay65_2.year, cDay65_2.month, cDay65_2.day);

            DateStruct65 s65 = sDay65;
            DateClass65 c65 = cDay65;

            s65.year = 2000;
            c65.year = 2000;

            Console.WriteLine("s: {0}/{1}/{2}", s65.year, s65.month, s65.day);
            Console.WriteLine("c: {0}/{1}/{2}", c65.year, c65.month, c65.day);
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay65.year, sDay65.month, sDay65.day);
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay65.year, cDay65.month, cDay65.day);


        }

        //////////////////////////////////////////////////////////////////

        private void 육십육_Click(object sender, RoutedEventArgs e)
        {
            // 66. 클래스의 멤버, 필드와 상수

            Product66 p66 = new Product66();
            p66.name = "시계";
            p66.price = 100000;

            Console.WriteLine("{0} : {1:C}", p66.name, p66.price);
            Console.WriteLine("원주율 : {0}", MyMath66.PI);
            Console.WriteLine("한달은 평균 {0:F3}일", MyCalendar66.daysPerMonth);
        }

        //////////////////////////////////////////////////////////////////

        private void 육십칠_Click(object sender, RoutedEventArgs e)
        {
            // 67. 인스턴스 메소드와 스태틱 메소드

            Date67 xmas67 = new Date67();

            xmas67.year = 2018;
            xmas67.month = 12;
            xmas67.day = 25;

            Console.WriteLine("xmas : {0}/{1}/{2}는 {3}일째 되는 날입니다.", 
                xmas67.year, xmas67.month, xmas67.day, xmas67.DayOfYear());

            Date67 date67 = new Date67();
            if(date67.IsLeapYear(2018) == true)
            {
                Console.WriteLine("2018년은 윤년입니다.");
            }
            else
            {
                Console.WriteLine("2018년은 평년입니다.");
            }
        }

        //////////////////////////////////////////////////////////////////

        private void 육십팔_Click(object sender, RoutedEventArgs e)
        {
            // 68. 생성자 메소드

            Date68 birthday68 = new Date68(2000, 11, 22);
            Date68 christmas68 = new Date68(2018, 12, 25);
            Date68 firstDay68 = new Date68();

            birthday68.PrintDate68();
            christmas68.PrintDate68();
            firstDay68.PrintDate68();
        }

        //////////////////////////////////////////////////////////////////

        private void 육십구_Click(object sender, RoutedEventArgs e)
        {
            // 69. 속성(프로퍼티)

            Rectangle69 r69_1 = new Rectangle69();
            r69_1.SetWidth69(10.0);
            r69_1.SetHeight69(10.0);
            Console.WriteLine("r1의 면적은 {0}", r69_1.GetWidth69() * r69_1.GetHeight69());

            RectWithProp69 r69_2 = new RectWithProp69();
            r69_2.Width = 10.0;
            r69_2.Height = 10.0;
            Console.WriteLine("r2의 면적은 {0}", r69_2.Width * r69_2.Height);

            RectWithPropFull69 r69_3 = new RectWithPropFull69();
            r69_3.Width = 10.0;
            r69_3.Height = 10.0;
            Console.WriteLine("r3의 면적은 {0}", r69_3.Width * r69_3.Height);

            RectWithPropFull69 r69_4 = new RectWithPropFull69();
            r69_4.Width = 10.0;
            r69_4.Height = -10.0;
            Console.WriteLine("r3의 면적은 {0}", r69_4.Width * r69_4.Height);
        }

        //////////////////////////////////////////////////////////////////

        private void 구십삼_Click(object sender, RoutedEventArgs e)
        {
            // 93. 일반화 메소드(제네릭 메소드)

            int[] a93 = { 1, 2, 3 };
            double[] d93 = { 0.1, 0.2, 0.3 };
            string[] s93 = { "tiger", "lion", "zebra" };

            PrintArray<int>(a93);
            PrintArray<double>(d93);
            PrintArray<string>(s93);
        }

        private void PrintArray<T>(T[] a)
        {
            foreach (var item in a)
                Console.Write("{0,8}", item);
            Console.WriteLine();
        }


        //////////////////////////////////////////////////////////////////

        private void 구십사_Click(object sender, RoutedEventArgs e)
        {
            // 94. 일반화 클래스(제네릭 클래스)

            MyClass94<int> a94 = new MyClass94<int>(10);
            MyClass94<string> s94 = new MyClass94<string>(5);

            a94.Insert94(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            s94.Insert94("Tiger", "Lion", "Zebra", "Monkey", "Cow");

            a94.Print94();
            s94.Print94();

            Console.WriteLine("a.AddAll() : " + a94.AddAll94());
            Console.WriteLine("s.AddAll() : " + s94.AddAll94());
        }

        //////////////////////////////////////////////////////////////////

        private void 백이_Click(object sender, RoutedEventArgs e)
        {
            // 102. 컬렉션, ArrayList 사용

            ArrayList a102 = new ArrayList();
            Random r102 = new Random();

            PrintValues102(a102);

            for(int i = 0; i < 10; i++)
            {
                a102.Add(r102.Next(100));  // Next 메서드로 1~100까지 랜덤한 숫자 지정
            }

            PrintValues102(a102);
            a102.Sort();
            PrintValues102(a102);

            a102.RemoveAt(3);   // 3번 인덱스 값을 제거하고 a에 저장된 값을 출력
            PrintValues102(a102);
        }

        private void PrintValues102(ArrayList a)
        {
            Console.WriteLine("Print Values in ArrayList");
            Console.WriteLine("      Count = {0}", a.Count);
            Console.WriteLine("   Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write("    {0}", i);
            Console.WriteLine();
            Console.WriteLine();
        }

        //////////////////////////////////////////////////////////////////

        private void 백삼_Click(object sender, RoutedEventArgs e)
        {
            // 103. List<T> 컬렉션
            List<int> a103 = new List<int>();
            Random r103 = new Random();

            PrintValues103(a103);

            for (int i = 0; i < 10; i++)
            {
                a103.Add(r103.Next(100));  // Next 메서드로 1~100까지 랜덤한 숫자 지정
            }

            PrintValues103(a103);
            a103.Sort();
            PrintValues103(a103);

            a103.RemoveAt(3);   // 3번 인덱스 값을 제거하고 a에 저장된 값을 출력
            PrintValues103(a103);

        }

        private void PrintValues103(List<int> a)
        {
            Console.WriteLine("Print Values in List<int>");
            Console.WriteLine("      Count = {0}", a.Count);
            Console.WriteLine("   Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write("    {0}", i);
            Console.WriteLine();
            Console.WriteLine();
        }

        //////////////////////////////////////////////////////////////////

        private void 백사_Click(object sender, RoutedEventArgs e)
        {
            // 104. List<T>와 배열의 정렬

            List<string> lstNames104 = new List<string>();
            lstNames104.Add("dog");
            lstNames104.Add("cow");
            lstNames104.Add("rabbit");
            lstNames104.Add("goat");
            lstNames104.Add("sheep");
            lstNames104.Sort();

            foreach (string s in lstNames104)
                Console.Write(s + " ");
            Console.WriteLine();

            string[] arrNames104 = new string[100];
            arrNames104[0] = "dog";
            arrNames104[1] = "cow";
            arrNames104[2] = "rabbit";
            arrNames104[3] = "goat";
            arrNames104[4] = "sheep";
            Array.Sort(arrNames104);
            foreach (string s in arrNames104)
                Console.Write(s + " ");
            Console.WriteLine();

        }

        //////////////////////////////////////////////////////////////////

        private void 백십육_Click(object sender, RoutedEventArgs e)
        {
            // 116. 람다식


        }

        //////////////////////////////////////////////////////////////////

        private void 백십칠_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 백이십_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 백이십_Click_1(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 백이십일_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 백이십이_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 백이십사_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

    }
}
