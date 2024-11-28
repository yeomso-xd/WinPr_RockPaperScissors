namespace WinPr_RockPaperScissors
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Paper = new System.Windows.Forms.Button();
            this.button_Rock = new System.Windows.Forms.Button();
            this.button_Scissors = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Computer = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Paper);
            this.groupBox1.Controls.Add(this.button_Rock);
            this.groupBox1.Controls.Add(this.button_Scissors);
            this.groupBox1.Location = new System.Drawing.Point(97, 407);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(221, 252);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택창";
            // 
            // button_Paper
            // 
            this.button_Paper.Location = new System.Drawing.Point(67, 175);
            this.button_Paper.Margin = new System.Windows.Forms.Padding(6);
            this.button_Paper.Name = "button_Paper";
            this.button_Paper.Size = new System.Drawing.Size(93, 46);
            this.button_Paper.TabIndex = 0;
            this.button_Paper.Text = "보";
            this.button_Paper.UseVisualStyleBackColor = true;
            this.button_Paper.Click += new System.EventHandler(this.button_Paper_Click);
            // 
            // button_Rock
            // 
            this.button_Rock.Location = new System.Drawing.Point(67, 117);
            this.button_Rock.Margin = new System.Windows.Forms.Padding(6);
            this.button_Rock.Name = "button_Rock";
            this.button_Rock.Size = new System.Drawing.Size(93, 46);
            this.button_Rock.TabIndex = 11;
            this.button_Rock.Text = "바위";
            this.button_Rock.UseVisualStyleBackColor = true;
            this.button_Rock.Click += new System.EventHandler(this.button_Rock_Click);
            // 
            // button_Scissors
            // 
            this.button_Scissors.Location = new System.Drawing.Point(67, 59);
            this.button_Scissors.Margin = new System.Windows.Forms.Padding(6);
            this.button_Scissors.Name = "button_Scissors";
            this.button_Scissors.Size = new System.Drawing.Size(93, 46);
            this.button_Scissors.TabIndex = 10;
            this.button_Scissors.Text = "가위";
            this.button_Scissors.UseVisualStyleBackColor = true;
            this.button_Scissors.Click += new System.EventHandler(this.button_Scissors_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 635);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "사용자의 선택";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User.Location = new System.Drawing.Point(379, 419);
            this.pictureBox_User.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(201, 200);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User.TabIndex = 19;
            this.pictureBox_User.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "컴퓨터의 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Computer
            // 
            this.pictureBox_Computer.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer.Location = new System.Drawing.Point(379, 141);
            this.pictureBox_Computer.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Computer.Name = "pictureBox_Computer";
            this.pictureBox_Computer.Size = new System.Drawing.Size(201, 200);
            this.pictureBox_Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Computer.TabIndex = 17;
            this.pictureBox_Computer.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(87, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(117, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 53);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(45, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(98, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(219, 238);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "점수창";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "게임을 시작하지.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(407, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 45);
            this.label7.TabIndex = 23;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 764);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Computer);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "묵찌빠";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Paper;
        private System.Windows.Forms.Button button_Rock;
        private System.Windows.Forms.Button button_Scissors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Computer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}