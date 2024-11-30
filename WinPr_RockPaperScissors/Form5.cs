using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
 * - void ResetGame()
 * 
 * 3. 초기화 함수
 * - void InitializeTags()
 * - void InitializePictureBoxes()
 * 
 * 4. GUI 함수
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

            /* CPU의 선택을 사진으로 보여주기 */
            Gesture cpuGesture = (Gesture)cpuChoice;
            pictureBox_Computer.Image =
                (Image)Properties.Resources.ResourceManager.
                GetObject($"15-{cpuGesture.ToString().ToLower()}"); // Resources에서 이름 맞는 사진 찾아오기

            /* 결과 계산 */
            int result = (playerChoice - cpuChoice + TotalGestures) % TotalGestures;

            if (result == 0)                        // 무승부
            {
                MessageBox.Show($"무승부입니다! 당신도 {(Gesture)playerChoice}, CPU도 {cpuGesture}를 선택했어요.", "라운드 결과");
            }
            else if (result <= TotalGestures / 2)   // 플레이어 승리
            {
                winCount++;
                label_WinCount.Text = winCount.ToString();
                MessageBox.Show($"이번 라운드는 승리했어요! 당신은 {(Gesture)playerChoice}, CPU는 {cpuGesture}를 선택했습니다.", "라운드 결과");
            }
            else                                    // CPU 승리
            {
                loseCount++;
                label_LoseCount.Text = loseCount.ToString();
                MessageBox.Show($"이번 라운드는 패배했어요! 당신은 {(Gesture)playerChoice}, CPU는 {cpuGesture}를 선택했습니다.", "라운드 결과");
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



        /////////////// 초기화 함수 ///////////////
        private void InitializeTags()
        {
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
                }
            }
        }



        /////////////// GUI 함수 ///////////////
    }
}
