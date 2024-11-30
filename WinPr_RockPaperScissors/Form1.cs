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

        private void RSP_btn_Click(object sender, EventArgs e)
        {
            Form2 _Form = new Form2();
            _Form.Show();
        }

        private void MJP_btn_Click(object sender, EventArgs e)
        {
            Form3 _Form = new Form3();
            _Form.Show();
        }

        private void omo_btn_Click(object sender, EventArgs e)
        {
            Form4 _Form = new Form4();
            _Form.Show();
        }

        private void rps15_btn_Click(object sender, EventArgs e)
        {
            Form5 _Form = new Form5();
            _Form.Show();
            // 한 번에 여러 게임창을 열었을 때 변수명이 겹쳐도 잘 작동되네요! 왜지.
        }
    }
}
