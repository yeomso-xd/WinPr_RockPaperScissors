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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /////////////// 같이 적는 부분 시작! ///////////////

        // 승리횟수 = win, 패배횟수 = lose 의 초기값 0으로 설정
        private int win = 0;
        private int lose = 0;

        private void button_Scissors_Click(object sender, EventArgs e)
        {
            rotateFlag = true;
            pictureBox_User.Image = Properties.Resources.scissors;
            PlayGame(1); // '가위'는 1로 설정
        }

        private void button_Rock_Click(object sender, EventArgs e)
        {
            rotateFlag = true;
            pictureBox_User.Image = Properties.Resources.rock;
            PlayGame(0); // '바위'는 0로 설정
        }

        private void button_Paper_Click(object sender, EventArgs e)
        {
            rotateFlag = true;
            pictureBox_User.Image = Properties.Resources.paper;
            PlayGame(-1); // '보'는 -1로 설정
        }

        private void PlayGame(int playerChoice)
        {
            Random random = new Random();
            int R = random.Next(-1, 2); // 컴퓨터의 선택 (1=가위, 0=바위, -1=보)
            int res = playerChoice - R;
            if (R == 1) pictureBox_Computer.Image = Properties.Resources.scissors;
            if (R == 0) pictureBox_Computer.Image = Properties.Resources.rock;
            if (R == -1) pictureBox_Computer.Image = Properties.Resources.paper; // CPU 가위바위보 사진 변경

            if (res == 2 || res == -1) // 플레이어가 승리하는 경우
            {
                win++;
                MessageBox.Show("승리!");
            }
            else if (res == 0) // 승부가 무승부인 경우
            {
                MessageBox.Show("아쉽군요 무승부입니다!");
            }
            else if (res == 1 || res == -2) // 플레이어가 패배하는 경우
            {
                lose++;
                MessageBox.Show("패배하였습니다");
            }

            // 승리 및 패배 횟수를 화면에 표시
            label3.Text = win.ToString();
            label5.Text = lose.ToString();

            if (win == 3)
            {
                MessageBox.Show("플레이어가 3판을 먼저 이겼습니다! 축하합니다!");
                win = 0;
                lose = 0;
                label3.Text = win.ToString();
                label5.Text = lose.ToString();
            }
            else if (lose == 3)
            {
                MessageBox.Show("CPU가 3판을 먼저 이겼습니다! 축하합니다!");
                win = 0;
                lose = 0;
                label3.Text = win.ToString();
                label5.Text = lose.ToString();
            }
        }

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
    }
}
