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
    public partial class Form4 : Form
    {
        // 게임의 상태를 추적할 변수들
        private int userWins = 0;
        private int computerWins = 0;

        private string userChoice1;
        private string userChoice2;
        private string computerChoice1;
        private string computerChoice2;

        // Form 초기화 및 이벤트 핸들러 설정
        public Form4()
        {
            InitializeComponent();
            this.Load += Form4_Load;
        }

        // Form이 로드될 때 호출되는 메서드
        private void Form4_Load(object sender, EventArgs e)
        {
            ResetPictureBoxBorders();  // 초기화 시 PictureBox 테두리 초기화
        }

        // 첫 번째 버튼 (가위) 클릭 시, 사용자 선택 처리 및 컴퓨터 선택 호출
        private void button_Scissors1_Click(object sender, EventArgs e)
        {
            userChoice1 = "scissors";
            pictureBox_User1.Image = Properties.Resources.scissors;  // 사용자 이미지 업데이트

            GenerateComputerChoices1(); // 컴퓨터의 선택을 랜덤으로 결정
        }

        // 두 번째 버튼 (바위) 클릭 시, 사용자 선택 처리 및 컴퓨터 선택 호출
        private void button_Rock1_Click(object sender, EventArgs e)
        {
            userChoice1 = "rock";
            pictureBox_User1.Image = Properties.Resources.rock;

            GenerateComputerChoices1();
        }

        // 세 번째 버튼 (보) 클릭 시, 사용자 선택 처리 및 컴퓨터 선택 호출
        private void button_Paper1_Click(object sender, EventArgs e)
        {
            userChoice1 = "paper";
            pictureBox_User1.Image = Properties.Resources.paper;

            GenerateComputerChoices1();
        }

        // 네 번째 버튼 (가위) 클릭 시, 두 번째 사용자 선택 처리 및 컴퓨터 선택 호출
        private void button_Scissors2_Click(object sender, EventArgs e)
        {
            userChoice2 = "scissors";
            pictureBox_User2.Image = Properties.Resources.scissors;

            GenerateComputerChoices2();
        }

        // 두 번째 사용자 선택 (바위)
        private void button_Rock2_Click(object sender, EventArgs e)
        {
            userChoice2 = "rock";
            pictureBox_User2.Image = Properties.Resources.rock;

            GenerateComputerChoices2();
        }

        // 두 번째 사용자 선택 (보)
        private void button_Paper2_Click(object sender, EventArgs e)
        {
            userChoice2 = "paper";
            pictureBox_User2.Image = Properties.Resources.paper;

            GenerateComputerChoices2();
        }

        // 첫 번째 PictureBox에 대해 컴퓨터의 선택을 랜덤으로 결정하고 이미지 표시
        private void GenerateComputerChoices1()
        {
            Random random = new Random();
            string[] options = { "scissors", "rock", "paper" };

            // 컴퓨터의 첫 번째 선택을 랜덤으로 결정
            computerChoice1 = options[random.Next(3)];

            // 해당 선택에 맞는 이미지를 PictureBox에 표시
            pictureBox_Computer1.Image = (Image)Properties.Resources.ResourceManager.GetObject(computerChoice1);
        }

        // 두 번째 PictureBox에 대해 컴퓨터의 선택을 랜덤으로 결정하고 이미지 표시
        private void GenerateComputerChoices2()
        {
            Random random = new Random();
            string[] options = { "scissors", "rock", "paper" };

            // 컴퓨터의 두 번째 선택을 랜덤으로 결정
            computerChoice2 = options[random.Next(3)];

            // 해당 선택에 맞는 이미지를 PictureBox에 표시
            pictureBox_Computer2.Image = (Image)Properties.Resources.ResourceManager.GetObject(computerChoice2);
        }

        // 첫 번째 사용자가 PictureBox를 클릭했을 때 테두리 색상 변경 및 컴퓨터의 선택에 맞는 테두리 설정
        private void pictureBox_User1_Click(object sender, EventArgs e)
        {
            pictureBox_User1.BorderStyle = BorderStyle.Fixed3D;  // 선택된 PictureBox에 테두리 설정
            pictureBox_User1.Padding = new Padding(3);  // 테두리 두께 설정
            pictureBox_User1.BackColor = Color.Red;  // 테두리 색상 설정

            GenerateComputerChoiceForUserSelection();  // 컴퓨터의 선택을 랜덤으로 결정하고 테두리 색상 변경

            EvaluateResult(userChoice1);  // 선택한 값과 컴퓨터의 선택을 비교하여 결과 판별
        }

        // 두 번째 사용자가 PictureBox를 클릭했을 때 테두리 색상 변경 및 컴퓨터의 선택에 맞는 테두리 설정
        private void pictureBox_User2_Click(object sender, EventArgs e)
        {
            pictureBox_User2.BorderStyle = BorderStyle.Fixed3D;  // 선택된 PictureBox에 테두리 설정
            pictureBox_User2.Padding = new Padding(3);  // 테두리 두께 설정
            pictureBox_User2.BackColor = Color.Red;  // 테두리 색상 설정

            GenerateComputerChoiceForUserSelection();  // 컴퓨터의 선택을 랜덤으로 결정하고 테두리 색상 변경

            EvaluateResult(userChoice2);  // 선택한 값과 컴퓨터의 선택을 비교하여 결과 판별
        }

        // 게임 결과 평가 및 승리 조건 확인
        private void EvaluateResult(string userFinalChoice)
        {
            Random random = new Random();
            string computerFinalChoice = random.Next(2) == 0 ? computerChoice1 : computerChoice2; // 컴퓨터의 최종 선택

            // 승리 판정: 사용자와 컴퓨터의 선택 비교
            if ((userFinalChoice == "scissors" && computerFinalChoice == "paper") ||
                (userFinalChoice == "rock" && computerFinalChoice == "scissors") ||
                (userFinalChoice == "paper" && computerFinalChoice == "rock"))
            {
                userWins++;  // 사용자 승리 시 점수 증가
                MessageBox.Show("이번 라운드는 당신의 승리!");
            }
            else if (userFinalChoice == computerFinalChoice)
            {
                MessageBox.Show("무승부!");
            }
            else
            {
                computerWins++;  // 컴퓨터 승리 시 점수 증가
                MessageBox.Show("이번 라운드는 컴퓨터의 승리!");
            }

            UpdateScore();  // 점수 업데이트
            CheckGameOver();  // 게임 종료 확인
            ResetPictureBoxBorders(); //테두리 초기화
        }

        // 점수 표시를 업데이트
        private void UpdateScore()
        {
            UserScore.Text = $"{userWins}";  // 사용자 점수 업데이트
            ComputerScore.Text = $"{computerWins}";  // 컴퓨터 점수 업데이트
        }

        // 게임 종료 조건을 확인하고 결과에 따라 리셋
        private void CheckGameOver()
        {
            if (userWins == 3)
            {
                MessageBox.Show("당신의 승리!");
                ResetGame();  // 게임 리셋
            }
            else if (computerWins == 3)
            {
                MessageBox.Show("컴퓨터의 승리!");
                ResetGame();  // 게임 리셋
            }
        }

        // 게임 초기화 함수 (점수, 선택, 이미지 및 테두리 초기화)
        private void ResetGame()
        {
            // 점수 초기화
            userWins = 0;
            computerWins = 0;
            UpdateScore();

            // PictureBox 이미지 초기화
            pictureBox_User1.Image = Properties.Resources.scissors;
            pictureBox_User2.Image = Properties.Resources.scissors;
            pictureBox_Computer1.Image = Properties.Resources.scissors;
            pictureBox_Computer2.Image = Properties.Resources.scissors;

            // PictureBox 테두리 초기화
            ResetPictureBoxBorders();

            // 사용자 및 컴퓨터 선택 초기화
            userChoice1 = null;
            userChoice2 = null;
            computerChoice1 = null;
            computerChoice2 = null;
        }

        // PictureBox의 테두리를 초기화하는 함수
        private void ResetPictureBoxBorders()
        {
            // 사용자 PictureBox 테두리 초기화
            pictureBox_User1.BorderStyle = BorderStyle.None;
            pictureBox_User1.BackColor = Color.Transparent;

            pictureBox_User2.BorderStyle = BorderStyle.None;
            pictureBox_User2.BackColor = Color.Transparent;

            // 컴퓨터 PictureBox 테두리 초기화
            pictureBox_Computer1.BorderStyle = BorderStyle.None;
            pictureBox_Computer1.BackColor = Color.Transparent;

            pictureBox_Computer2.BorderStyle = BorderStyle.None;
            pictureBox_Computer2.BackColor = Color.Transparent;
        }

        // 컴퓨터의 선택을 랜덤으로 결정하고, 선택된 PictureBox에 테두리 색상 적용
        private void GenerateComputerChoiceForUserSelection()
        {
            Random random = new Random();
            string[] options = { "scissors", "rock", "paper" };

            // 컴퓨터의 선택을 랜덤으로 결정
            string computerChoice = options[random.Next(3)];

            // 컴퓨터 선택에 맞는 pictureBox에 파란색 테두리 적용
            if (computerChoice == "scissors")
            {
                pictureBox_Computer1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox_Computer1.Padding = new Padding(3);
                pictureBox_Computer1.BackColor = Color.Blue;
            }
            else if (computerChoice == "rock")
            {
                pictureBox_Computer2.BorderStyle = BorderStyle.FixedSingle;
                pictureBox_Computer2.Padding = new Padding(3);
                pictureBox_Computer2.BackColor = Color.Blue;
            }
            else if (computerChoice == "paper")
            {
                pictureBox_Computer1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox_Computer1.Padding = new Padding(3);
                pictureBox_Computer1.BackColor = Color.Blue;
            }
        }
    }
}
