using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ChatGPT 도움 엄청나게 많이 받았어요! */

/* [ 목차 ]
 * 
 * 1. 정의
 * 
 * 2. 주요 함수
 * - void PlayGame(int PlayerChoice)
 * - void ResetGame
 * - void PictureBox_MouseEnter
 * - void PictureBox_MouseLeave
 * - void linkLabel1_LinkClicked
 * 
 * 3. 초기화 함수
 * - void InitializeTags
 * - void InitializePictureBoxes
 * 
 */

namespace WinPr_RockPaperScissors
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InitializeTags();
            InitializePictureBoxes();
        }

        /////////////// 정의 ///////////////
        private enum Gesture
        {
            Rock = 0, Gun = 1, Lightning = 2,
            Devil = 3, Dragon = 4, Water = 5,
            Air = 6, Paper = 7, Sponge = 8,
            Wolf = 9, Tree = 10, Human = 11,
            Snake = 12, Scissors = 13, Fire = 14
        }

        //List<PictureBox> gesturePictureBoxes = new List<PictureBox>();

        private int winCount = 0;
        private int loseCount = 0;
        private const int TotalGestures = 15;

        private Random random = new Random();



        /////////////// 주요 함수 ///////////////
        private void PlayGame(int playerChoice)
        {
            int cpuChoice = random.Next(0, TotalGestures); // 0~14
            Gesture cpuGesture = (Gesture)cpuChoice;

            /* CPU의 선택을 사진으로 보여주기 */
            pictureBox_Computer.Image =
                (Image)Properties.Resources.ResourceManager.
                GetObject($"15-{cpuGesture.ToString().ToLower()}"); // Resources에서 이름 맞는 사진 찾아오기

            /* 결과 계산 */
            int result = (playerChoice - cpuChoice + TotalGestures) % TotalGestures;

            if (result == 0)                        // 무승부
            {
                MessageBox.Show($"무승부입니다!\n당신도 {(Gesture)playerChoice}, CPU도 {cpuGesture}를 선택했어요.", "라운드 결과");
            }
            else if (result <= TotalGestures / 2)   // 플레이어 승리
            {
                winCount++;
                label_WinCount.Text = winCount.ToString();
                MessageBox.Show($"이번 라운드는 승리했어요!\n당신은 {(Gesture)playerChoice}, CPU는 {cpuGesture}를 선택했습니다.", "라운드 결과");
            }
            else                                    // CPU 승리
            {
                loseCount++;
                label_LoseCount.Text = loseCount.ToString();
                MessageBox.Show($"이번 라운드는 패배했어요!\n당신은 {(Gesture)playerChoice}, CPU는 {cpuGesture}를 선택했습니다.", "라운드 결과");
            }

            /* 게임이 끝났는지 체크 */
            if (winCount == 3 || loseCount == 3)
            {
                string winner = winCount == 3 ? "유저" : "CPU"; // winCount가 3이면 You를, 아니면 CPU를 winner에 대입
                MessageBox.Show($"{winner}가 최종적으로 승리했습니다!", "게임 끝");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            winCount = 0;
            loseCount = 0;
            label_WinCount.Text = "0";
            label_LoseCount.Text = "0";
            pictureBox_Computer.Image = (Image)Properties.Resources.ResourceManager.GetObject("15-rock");
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox hoveredPictureBox = sender as PictureBox;
            if (hoveredPictureBox == null) return;

            int hoveredIndex = (int)hoveredPictureBox.Tag;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Tag is int otherIndex) // TODO: 이 부분이 이해가 안 됨
                {
                    int result = (hoveredIndex - otherIndex + TotalGestures) % TotalGestures;

                    Label overlayLabel = new Label // 오버레이로 쓸 라벨 생성
                    {
                        BackColor = result <= TotalGestures / 2
                                ? Color.FromArgb(70, Color.Green) // true면 이기는 손모양이니 초록
                                : Color.FromArgb(70, Color.Red), // false면 지는 손모양이니 빨강
                        Size = pictureBox.Size,
                        Location = new Point(0, 0),
                        Text = result <= TotalGestures / 2 ? "Win" : "Lose",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Gulim", 12, FontStyle.Bold),
                        ForeColor = Color.White
                    };

                    if (result != 0) pictureBox.Controls.Add(overlayLabel);
                }
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Controls.Clear(); // 오버레이 없앰
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.umop.com/rps15.htm");
        }




        /////////////// 초기화 함수 ///////////////
        private void InitializeTags()
        {
            // TODO: 누가 자동화 할 수 있으면 해 주세요...
            // Designer에서 태그 달면 String밖에 안 된대서 코드로 달음
            pictureBox_Rock.Tag = 0;
            pictureBox_Gun.Tag = 1;
            pictureBox_Lightning.Tag = 2;
            pictureBox_Devil.Tag = 3;
            pictureBox_Dragon.Tag = 4;
            pictureBox_Water.Tag = 5;
            pictureBox_Air.Tag = 6;
            pictureBox_Paper.Tag = 7;
            pictureBox_Sponge.Tag = 8;
            pictureBox_Wolf.Tag = 9;
            pictureBox_Tree.Tag = 10;
            pictureBox_Human.Tag = 11;
            pictureBox_Snake.Tag = 12;
            pictureBox_Scissors.Tag = 13;
            pictureBox_Fire.Tag = 14;
        }

        private void InitializePictureBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Tag != null)
                {
                    //gesturePictureBoxes.Add(pictureBox);
                    pictureBox.Click += (s, e) => PlayGame((int)pictureBox.Tag);
                    pictureBox.MouseEnter += (s, e) => PictureBox_MouseEnter(s, e);
                    pictureBox.MouseLeave += (s, e) => PictureBox_MouseLeave(s, e);
                }
            }
        }
    }
}
