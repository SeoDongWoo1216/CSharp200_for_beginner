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
            
        }


        //////////////////////////////////////////////////////////////////
        private void 사십구_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 오십_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 오십일_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 오십이_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 오십삼_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 오십사_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 오십오_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////

        private void 오십육_Click(object sender, RoutedEventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////


    }
}
