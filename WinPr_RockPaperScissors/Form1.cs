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

        private void pictureBox2_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("왜 LoadCompleted 이벤트 안 발생하냐.");
        }

        bool rotateFlag = true; // 1에서 쓰이는 플래그
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            /* 1. '사용자의 선택' 그림을 180도 돌려주는 코드 */
            if (rotateFlag)
            {
                Image imageToRotate = pictureBox2.Image;
                imageToRotate.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                pictureBox2.Image = imageToRotate;
                rotateFlag = false;
            } // TODO: 가위, 바위, 보로 사진이 바뀔 때 rotateFlag = true; 해주셔야 해요.
        }
    }
}
