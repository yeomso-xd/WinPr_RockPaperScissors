namespace WinPr_RockPaperScissors
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Paper1 = new System.Windows.Forms.Button();
            this.button_Rock1 = new System.Windows.Forms.Button();
            this.button_Scissors1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_User1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Computer1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComputerScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserScore = new System.Windows.Forms.Label();
            this.pictureBox_User2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Computer2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Paper2 = new System.Windows.Forms.Button();
            this.button_Rock2 = new System.Windows.Forms.Button();
            this.button_Scissors2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Paper1);
            this.groupBox1.Controls.Add(this.button_Rock1);
            this.groupBox1.Controls.Add(this.button_Scissors1);
            this.groupBox1.Location = new System.Drawing.Point(237, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 183);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택1";
            // 
            // button_Paper1
            // 
            this.button_Paper1.Location = new System.Drawing.Point(52, 131);
            this.button_Paper1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Paper1.Name = "button_Paper1";
            this.button_Paper1.Size = new System.Drawing.Size(72, 34);
            this.button_Paper1.TabIndex = 0;
            this.button_Paper1.Text = "보";
            this.button_Paper1.UseVisualStyleBackColor = true;
            this.button_Paper1.Click += new System.EventHandler(this.button_Paper1_Click);
            // 
            // button_Rock1
            // 
            this.button_Rock1.Location = new System.Drawing.Point(52, 88);
            this.button_Rock1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Rock1.Name = "button_Rock1";
            this.button_Rock1.Size = new System.Drawing.Size(72, 34);
            this.button_Rock1.TabIndex = 11;
            this.button_Rock1.Text = "바위";
            this.button_Rock1.UseVisualStyleBackColor = true;
            this.button_Rock1.Click += new System.EventHandler(this.button_Rock1_Click);
            // 
            // button_Scissors1
            // 
            this.button_Scissors1.Location = new System.Drawing.Point(52, 44);
            this.button_Scissors1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Scissors1.Name = "button_Scissors1";
            this.button_Scissors1.Size = new System.Drawing.Size(72, 34);
            this.button_Scissors1.TabIndex = 10;
            this.button_Scissors1.Text = "가위";
            this.button_Scissors1.UseVisualStyleBackColor = true;
            this.button_Scissors1.Click += new System.EventHandler(this.button_Scissors1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "사용자의 선택";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_User1
            // 
            this.pictureBox_User1.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User1.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User1.Location = new System.Drawing.Point(237, 264);
            this.pictureBox_User1.Name = "pictureBox_User1";
            this.pictureBox_User1.Size = new System.Drawing.Size(155, 145);
            this.pictureBox_User1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User1.TabIndex = 26;
            this.pictureBox_User1.TabStop = false;
            this.pictureBox_User1.Click += new System.EventHandler(this.pictureBox_User1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "컴퓨터의 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Computer1
            // 
            this.pictureBox_Computer1.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer1.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer1.Location = new System.Drawing.Point(237, 67);
            this.pictureBox_Computer1.Name = "pictureBox_Computer1";
            this.pictureBox_Computer1.Size = new System.Drawing.Size(155, 145);
            this.pictureBox_Computer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Computer1.TabIndex = 24;
            this.pictureBox_Computer1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComputerScore);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UserScore);
            this.groupBox2.Location = new System.Drawing.Point(31, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 173);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "점수창";
            // 
            // ComputerScore
            // 
            this.ComputerScore.AutoSize = true;
            this.ComputerScore.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComputerScore.ForeColor = System.Drawing.Color.IndianRed;
            this.ComputerScore.Location = new System.Drawing.Point(90, 40);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(41, 40);
            this.ComputerScore.TabIndex = 8;
            this.ComputerScore.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "게임을 시작하지.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(67, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // UserScore
            // 
            this.UserScore.AutoSize = true;
            this.UserScore.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserScore.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.UserScore.Location = new System.Drawing.Point(35, 40);
            this.UserScore.Name = "UserScore";
            this.UserScore.Size = new System.Drawing.Size(41, 40);
            this.UserScore.TabIndex = 6;
            this.UserScore.Text = "0";
            // 
            // pictureBox_User2
            // 
            this.pictureBox_User2.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User2.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User2.Location = new System.Drawing.Point(458, 264);
            this.pictureBox_User2.Name = "pictureBox_User2";
            this.pictureBox_User2.Size = new System.Drawing.Size(155, 145);
            this.pictureBox_User2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User2.TabIndex = 31;
            this.pictureBox_User2.TabStop = false;
            this.pictureBox_User2.Click += new System.EventHandler(this.pictureBox_User2_Click);
            // 
            // pictureBox_Computer2
            // 
            this.pictureBox_Computer2.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer2.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer2.Location = new System.Drawing.Point(458, 66);
            this.pictureBox_Computer2.Name = "pictureBox_Computer2";
            this.pictureBox_Computer2.Size = new System.Drawing.Size(155, 145);
            this.pictureBox_Computer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Computer2.TabIndex = 30;
            this.pictureBox_Computer2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Paper2);
            this.groupBox3.Controls.Add(this.button_Rock2);
            this.groupBox3.Controls.Add(this.button_Scissors2);
            this.groupBox3.Location = new System.Drawing.Point(458, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 183);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "선택2";
            // 
            // button_Paper2
            // 
            this.button_Paper2.Location = new System.Drawing.Point(52, 131);
            this.button_Paper2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Paper2.Name = "button_Paper2";
            this.button_Paper2.Size = new System.Drawing.Size(72, 34);
            this.button_Paper2.TabIndex = 0;
            this.button_Paper2.Text = "보";
            this.button_Paper2.UseVisualStyleBackColor = true;
            this.button_Paper2.Click += new System.EventHandler(this.button_Paper2_Click);
            // 
            // button_Rock2
            // 
            this.button_Rock2.Location = new System.Drawing.Point(52, 88);
            this.button_Rock2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Rock2.Name = "button_Rock2";
            this.button_Rock2.Size = new System.Drawing.Size(72, 34);
            this.button_Rock2.TabIndex = 11;
            this.button_Rock2.Text = "바위";
            this.button_Rock2.UseVisualStyleBackColor = true;
            this.button_Rock2.Click += new System.EventHandler(this.button_Rock2_Click);
            // 
            // button_Scissors2
            // 
            this.button_Scissors2.Location = new System.Drawing.Point(52, 44);
            this.button_Scissors2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_Scissors2.Name = "button_Scissors2";
            this.button_Scissors2.Size = new System.Drawing.Size(72, 34);
            this.button_Scissors2.TabIndex = 10;
            this.button_Scissors2.Text = "가위";
            this.button_Scissors2.UseVisualStyleBackColor = true;
            this.button_Scissors2.Click += new System.EventHandler(this.button_Scissors2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "                                  ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 704);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox_User2);
            this.Controls.Add(this.pictureBox_Computer2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_User1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Computer1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form4";
            this.Text = "하나빼기";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Paper1;
        private System.Windows.Forms.Button button_Rock1;
        private System.Windows.Forms.Button button_Scissors1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_User1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Computer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ComputerScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserScore;
        private System.Windows.Forms.PictureBox pictureBox_User2;
        private System.Windows.Forms.PictureBox pictureBox_Computer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Paper2;
        private System.Windows.Forms.Button button_Rock2;
        private System.Windows.Forms.Button button_Scissors2;
        private System.Windows.Forms.Label label3;
    }
}