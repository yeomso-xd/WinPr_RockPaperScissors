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

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            rotateFlag = true;
            if (radioButton_Scissors.Checked)
            {
                pictureBox_User.Image = Properties.Resources.scissors;
                pictureBox_User.Refresh();
            }
            else if (radioButton_Rock.Checked)
            {
                pictureBox_User.Image = Properties.Resources.rock;
                pictureBox_User.Refresh();
            }
            else
            {
                pictureBox_User.Image = Properties.Resources.paper;
                pictureBox_User.Refresh();
            }
        }
    }
}
