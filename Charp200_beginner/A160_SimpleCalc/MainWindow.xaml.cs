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

namespace A160_SimpleCalc
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        //// 전역변수 영역
        private double saveValue;    // 첫번째로 입력한 숫자를 저장할 전역변수
        private string devOperator;  // 연산기호를 문자열로 저장할 전역변수

        public MainWindow()
        {
            InitializeComponent();
        }


        //// 이벤트 메서드 영역


        // 숫자 버튼 클릭 처리
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            txtLabel.Clear();
            Button Numbtn = sender as Button;  // 버튼 객체 생성
            string number = Numbtn.Content.ToString();  // 숫자버튼의 content값을 저장(숫자버튼의 숫자를 임시 변수에 저장)

            if (txtResult.Text == "0")  // 텍스트박스에 0이있을때는 그냥 클릭한 숫자만 출력
            {
                txtResult.Text = number;
            }
            else  // 텍스트박스에 숫자 하나라도있으면, 전에 클릭한 숫자에 이어서 지금 클릭한 숫자를 이어서 출력
            {
                txtResult.Text = txtResult.Text + number;
            }
        }


        // 연산 버튼 클릭 처리
        private void Operators_Click(object sender, RoutedEventArgs e)
        {
            // 아무 숫자 입력하지도않고 연산기호부터 클릭했을때 오류 제어
            if (txtResult.Text == "")
            {
                // txtResult.Text = "숫자를 먼저 입력해주세요";
                txtLabel.Text = "숫자를 먼저 입력해주세요";
                return;
            }

            Button Operbtn = sender as Button;  // 버튼 객체 생성
            saveValue = double.Parse(txtResult.Text);
            devOperator = Operbtn.Content.ToString();
            txtResult.Clear();
        }


        // '=' 버튼 처리 : 전역변수 값을 토대로 계산값을 텍스트박스에 출력
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "" || devOperator == null || devOperator == "" )
            {
                //txtResult.Text = "'='버튼을 먼저 누르셨습니다.";
                txtLabel.Text = "'='버튼을 먼저 누르셨습니다.";

                return;
            }
            switch(devOperator)
            {
                case "+":
                    txtResult.Text = (saveValue + double.Parse(txtResult.Text)).ToString();
                    break;
                
                case "-":
                    txtResult.Text = (saveValue - double.Parse(txtResult.Text)).ToString();
                    break;

                case "*":
                    txtResult.Text = (saveValue * double.Parse(txtResult.Text)).ToString();
                    break;

                case "/":
                    // 0으로 나누는것을 방지
                    if (txtResult.Text == "0")
                    {
                        //txtResult.Text = "0으로 나눌 수 없습니다";
                        txtLabel.Text = "0으로 나눌 수 없습니다";

                        return;
                    }

                    txtResult.Text = (saveValue / double.Parse(txtResult.Text)).ToString();
                    break;
            }
        }

        // 클리어 버튼 처리
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            saveValue = 0;
            devOperator = "";
            txtResult.Clear();
            txtLabel.Clear();
        }

        // 소숫점 버튼 처리
        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if(txtResult.Text.Contains(".") == false)  // 소수점 두개 이상 찍히는거 방지(미리 소수점이있으면 점이 안찍힘)
                txtResult.Text = txtResult.Text + ".";
        }
    }
}
