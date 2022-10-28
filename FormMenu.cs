using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMatchingGame
{
    public partial class FormMenu : Form
    {
        int r = 4; // so hang theo level co gia tri la 4, 5, 6
        int level = 12; // level co 3 gia tri la 12, 20, 30
        int totalTime = 60;
        List<int> numbers = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string username = "admin1";
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn;
            btn = sender as Button;
            username = txtUsername.Text.ToString();

            if (username == "")
            {
                MessageBox.Show("Please input your name!!!");
                return;
            }

            if (btn.Text.ToString() == "Hard")
            {
                r = 6;
                level = 30;
                totalTime = 90;
                numbers = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15 };
                MMGame starGame = new MMGame("Hard", r, level, totalTime, numbers, username);
                starGame.Show();
            }
            else if (btn.Text.ToString() == "Easy")
            {
                r = 4;
                level = 12;
                totalTime = 60;
                numbers = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
                MMGame starGame = new MMGame("Easy", r, level, totalTime, numbers, username);
                starGame.Show();
            }
            else
            {
                r = 5;
                level = 20;
                totalTime = 70;
                numbers = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };
                MMGame starGame = new MMGame("Normal", r, level, totalTime, numbers, username);
                starGame.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTop3 frm = new FormTop3();
            frm.Show();
        }
    }
}
