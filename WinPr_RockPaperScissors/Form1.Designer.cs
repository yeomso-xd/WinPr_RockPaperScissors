namespace WinPr_RockPaperScissors
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Computer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Paper = new System.Windows.Forms.RadioButton();
            this.radioButton_Rock = new System.Windows.Forms.RadioButton();
            this.radioButton_Scissors = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.게임모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.묵찌빠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPS15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPS15ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Computer
            // 
            this.pictureBox_Computer.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_Computer.Location = new System.Drawing.Point(379, 142);
            this.pictureBox_Computer.Name = "pictureBox_Computer";
            this.pictureBox_Computer.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Computer.TabIndex = 0;
            this.pictureBox_Computer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "컴퓨터의 선택";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Image = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User.InitialImage = global::WinPr_RockPaperScissors.Properties.Resources.rock;
            this.pictureBox_User.Location = new System.Drawing.Point(379, 456);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User.TabIndex = 2;
            this.pictureBox_User.TabStop = false;
            this.pictureBox_User.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_User_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "사용자의 선택";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Paper);
            this.groupBox1.Controls.Add(this.radioButton_Rock);
            this.groupBox1.Controls.Add(this.radioButton_Scissors);
            this.groupBox1.Location = new System.Drawing.Point(97, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택창";
            // 
            // radioButton_Paper
            // 
            this.radioButton_Paper.AutoSize = true;
            this.radioButton_Paper.Location = new System.Drawing.Point(65, 176);
            this.radioButton_Paper.Name = "radioButton_Paper";
            this.radioButton_Paper.Size = new System.Drawing.Size(65, 28);
            this.radioButton_Paper.TabIndex = 2;
            this.radioButton_Paper.Text = "보";
            this.radioButton_Paper.UseVisualStyleBackColor = true;
            this.radioButton_Paper.CheckedChanged += new System.EventHandler(this.changeUserChoice);
            // 
            // radioButton_Rock
            // 
            this.radioButton_Rock.AutoSize = true;
            this.radioButton_Rock.Checked = true;
            this.radioButton_Rock.Location = new System.Drawing.Point(65, 121);
            this.radioButton_Rock.Name = "radioButton_Rock";
            this.radioButton_Rock.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Rock.TabIndex = 1;
            this.radioButton_Rock.TabStop = true;
            this.radioButton_Rock.Text = "바위";
            this.radioButton_Rock.UseVisualStyleBackColor = true;
            this.radioButton_Rock.CheckedChanged += new System.EventHandler(this.changeUserChoice);
            // 
            // radioButton_Scissors
            // 
            this.radioButton_Scissors.AutoSize = true;
            this.radioButton_Scissors.Location = new System.Drawing.Point(65, 66);
            this.radioButton_Scissors.Name = "radioButton_Scissors";
            this.radioButton_Scissors.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Scissors.TabIndex = 0;
            this.radioButton_Scissors.Text = "가위";
            this.radioButton_Scissors.UseVisualStyleBackColor = true;
            this.radioButton_Scissors.CheckedChanged += new System.EventHandler(this.changeUserChoice);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게임모드ToolStripMenuItem,
            this.묵찌빠ToolStripMenuItem,
            this.rPS15ToolStripMenuItem,
            this.rPS15ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 게임모드ToolStripMenuItem
            // 
            this.게임모드ToolStripMenuItem.Name = "게임모드ToolStripMenuItem";
            this.게임모드ToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.게임모드ToolStripMenuItem.Text = "가위바위보";
            // 
            // 묵찌빠ToolStripMenuItem
            // 
            this.묵찌빠ToolStripMenuItem.Name = "묵찌빠ToolStripMenuItem";
            this.묵찌빠ToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.묵찌빠ToolStripMenuItem.Text = "묵찌빠";
            // 
            // rPS15ToolStripMenuItem
            // 
            this.rPS15ToolStripMenuItem.Name = "rPS15ToolStripMenuItem";
            this.rPS15ToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.rPS15ToolStripMenuItem.Text = "하나빼기";
            // 
            // rPS15ToolStripMenuItem1
            // 
            this.rPS15ToolStripMenuItem1.Name = "rPS15ToolStripMenuItem1";
            this.rPS15ToolStripMenuItem1.Size = new System.Drawing.Size(110, 36);
            this.rPS15ToolStripMenuItem1.Text = "RPS-15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(122, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(84, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(41, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 53);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(97, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 238);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "점수창";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "게임을 시작하지.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "게임 시작";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Computer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "가위바위보!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Computer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Computer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Paper;
        private System.Windows.Forms.RadioButton radioButton_Rock;
        private System.Windows.Forms.RadioButton radioButton_Scissors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 게임모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 묵찌빠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rPS15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rPS15ToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

