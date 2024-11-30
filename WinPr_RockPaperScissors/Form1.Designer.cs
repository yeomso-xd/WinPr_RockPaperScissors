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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rps15_btn = new System.Windows.Forms.Button();
            this.omo_btn = new System.Windows.Forms.Button();
            this.MJP_btn = new System.Windows.Forms.Button();
            this.RSP_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothic", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(127, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "다같이 가위바위보";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rps15_btn);
            this.groupBox1.Controls.Add(this.omo_btn);
            this.groupBox1.Controls.Add(this.MJP_btn);
            this.groupBox1.Controls.Add(this.RSP_btn);
            this.groupBox1.Location = new System.Drawing.Point(36, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 400);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rps15_btn
            // 
            this.rps15_btn.Location = new System.Drawing.Point(337, 201);
            this.rps15_btn.Name = "rps15_btn";
            this.rps15_btn.Size = new System.Drawing.Size(195, 65);
            this.rps15_btn.TabIndex = 3;
            this.rps15_btn.Text = "rps - 15";
            this.rps15_btn.UseVisualStyleBackColor = true;
            this.rps15_btn.Click += new System.EventHandler(this.rps15_btn_Click);
            // 
            // omo_btn
            // 
            this.omo_btn.Location = new System.Drawing.Point(43, 201);
            this.omo_btn.Name = "omo_btn";
            this.omo_btn.Size = new System.Drawing.Size(195, 65);
            this.omo_btn.TabIndex = 2;
            this.omo_btn.Text = "하나빼기";
            this.omo_btn.UseVisualStyleBackColor = true;
            this.omo_btn.Click += new System.EventHandler(this.omo_btn_Click);
            // 
            // MJP_btn
            // 
            this.MJP_btn.Location = new System.Drawing.Point(337, 40);
            this.MJP_btn.Name = "MJP_btn";
            this.MJP_btn.Size = new System.Drawing.Size(195, 65);
            this.MJP_btn.TabIndex = 1;
            this.MJP_btn.Text = "묵찌빠";
            this.MJP_btn.UseVisualStyleBackColor = true;
            this.MJP_btn.Click += new System.EventHandler(this.MJP_btn_Click);
            // 
            // RSP_btn
            // 
            this.RSP_btn.Location = new System.Drawing.Point(43, 40);
            this.RSP_btn.Name = "RSP_btn";
            this.RSP_btn.Size = new System.Drawing.Size(195, 65);
            this.RSP_btn.TabIndex = 0;
            this.RSP_btn.Text = "가위바위보";
            this.RSP_btn.UseVisualStyleBackColor = true;
            this.RSP_btn.Click += new System.EventHandler(this.RSP_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 764);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "게임 선택";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rps15_btn;
        private System.Windows.Forms.Button omo_btn;
        private System.Windows.Forms.Button MJP_btn;
        private System.Windows.Forms.Button RSP_btn;
    }
}

