using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPr_RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /////////////// 같이 적는 부분 시작! ///////////////

        // 승리횟수 = win, 패배횟수 = lose 의 초기값 0으로 설정
        private int win = 0;
        private int lose = 0;

        /* 01~02 */
        private int CpuChoice()
        {
            Random random = new Random(); // Random 객체 생성
            int cpuChoice = random.Next(0, 3); // 0부터 2까지의 랜덤 값 생성 (0, 1, 2)

            return cpuChoice;
        }

        /* 3-1 */

        /* 3-2 */
        private void Rock_Click(object sender, EventArgs e)
        {
            int a = CpuChoice();

            if (a == 0)
            {
                win += 1; //승리 시 win 1씩 증가
                MessageBox.Show("승리!");
            }
            else if (a == 1)
            {
                MessageBox.Show("무승부!");
            }
            else if (a == 2)
            {
                lose += 1; //패배 시 lose 1씩 증가
                MessageBox.Show("패배!");
            }
        }

        /* 3-3 */
        
        // 승리 및 패배 횟수 변수
        int winCount = 0;
        int loseCount = 0;

        // '보' 버튼 클릭 이벤트 핸들러
        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame(2); // '보'는 2로 설정
        }

        private void PlayGame(int playerChoice)
        {
            Random random = new Random();
            int a = random.Next(0, 3); // 컴퓨터의 선택 (0=가위, 1=바위, 2=보)

            if (playerChoice == 2) // 플레이어가 '보'를 선택한 경우
            {
                if (a == 0) // 컴퓨터가 가위
                {
                    MessageBox.Show("무승부! 컴퓨터도 가위를 냈습니다.", "결과");
                }
                else if (a == 1) // 컴퓨터가 바위
                {
                    loseCount++;
                    MessageBox.Show("패배! 컴퓨터는 바위를 냈습니다.", "결과");
                }
                else if (a == 2) // 컴퓨터가 보
                {
                    winCount++;
                    MessageBox.Show("승리! 컴퓨터는 보를 냈습니다.", "결과");
                }
            }

            // 승리 및 패배 횟수를 화면에 표시
            //lblWinCount.Text = "승리: " + winCount.ToString();
            //lblLoseCount.Text = "패배: " + loseCount.ToString();
        }

        /* 04~05 */

        /////////////// 같이 적는 부분 끝! ///////////////



        /////////////// GUI를 위한 코드 ///////////////
        bool rotateFlag = true; // 1에서 쓰이는 플래그
        private void pictureBox_User_Paint(object sender, PaintEventArgs e)
        {
            /* 1. '사용자의 선택' 그림을 180도 돌려주는 코드 */
            if (rotateFlag)
            {
                Image imageToRotate = pictureBox_User.Image;
                imageToRotate.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                pictureBox_User.Image = imageToRotate;
                rotateFlag = false;
            }
        }

        private void changeUserChoice(object sender, EventArgs e)
        {
            RadioButton R = sender as RadioButton;
            rotateFlag = true;

            if (R == radioButton_Scissors)  pictureBox_User.Image = Properties.Resources.scissors;
            if (R == radioButton_Rock)      pictureBox_User.Image = Properties.Resources.rock;
            if (R == radioButton_Paper)     pictureBox_User.Image = Properties.Resources.paper;

            pictureBox_User.Refresh();
        }
    }
}
