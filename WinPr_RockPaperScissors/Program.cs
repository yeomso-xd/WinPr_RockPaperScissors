using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPr_RockPaperScissors
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void CpuChoice(string[] args)
        {
            Random random = new Random(); // Random 객체 생성
            int cpuChoice = random.Next(0, 3); // 0부터 2까지의 랜덤 값 생성 (0, 1, 2)
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
