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

        // 승리횟수 = win, 패배횟수 = lose 의 초기값 0으로 설정
        private int win = 0;
        private int lose = 0;

        private void Rock_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(0, 3); // 0, 1, 2 중 랜덤으로 선택

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

    }
}
