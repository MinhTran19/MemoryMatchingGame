using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Cải tiến game
 * Thêm level: easy - 12 ô, normal - 20 ô, hard - 30 ô và chỉnh lại thời gian chơi tùy mức độ
 * Thêm danh sách top 3 điểm cao nhất
*/

namespace MemoryMatchingGame
{
    public partial class MMGame : Form
    {
        List<int> numbers = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        List<PictureBox> pictures = new List<PictureBox>();
        string firstChoice;
        string secondChoice;
        PictureBox picA;
        PictureBox picB;
        int tries;
        int totalTime = 60;
        int countDownTime;
        bool gameOver = false;
        string levelTitle = "Easy";
        int i = 0;
        int r = 4; // so hang theo level co gia tri la 4, 5, 6
        int level = 12; // level co 3 gia tri la 12, 20, 30
        string Username;

    public MMGame()
        {
            
            InitializeComponent();
            LoadPictures();
        }

        public MMGame(string lt, int R, int L, int tt, List<int> arr, string name)
        {
            InitializeComponent();

            numbers = arr;
            levelTitle = lt;
            r = R;
            level = L;
            totalTime = tt;
            Username = name;
            LoadPictures();
        }

        private void LoadPictures()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;
            lbLevel.Text = "Level: " + levelTitle;
            pictures.Clear();

            for (int i = 0; i < level; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 80;
                newPic.Width = 80;
                newPic.BackColor = Color.DimGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic); // pictures thêm phần tử vào dãy 

                if (rows < r)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos += 90;
                }

                if (rows == r)
                {
                    rows = 0;
                    topPos += 90;
                    leftPos = 20;
                }
            }

            RestartGame();
        }

        private void RestartGame()
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList(); // randomlist dùng random dãy phần tử từ mảng numbers
            numbers = randomList; // gán ngược lại dãy phần tử đã thay đổi trình tự cho numbers

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
                string a = pictures[i].Tag.ToString();
            }

            tries = 0;
            lbNotice.Text = "Mismatched: " + tries + " times.";
            lbTimeLeft.Text = "Time Left: " + totalTime;
            gameOver = false;
            GameTimer.Start();
            countDownTime = totalTime;
        }

        private void CheckPictures(PictureBox A, PictureBox B)
        {
            

            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;

                i += 2;

                if (i == pictures.Count)
                {
                    GameOver("You Win!!!" + countDownTime);
                }
            }
            else
            {
                tries++;
                lbNotice.Text = "Mismatched: " + tries + " times.";
            }

            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            
        }

        private void GameOver(string msg)
        {
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Click Restart to Play Again.", "Bot says: ");
            infoObject obj = new infoObject();

            obj.UserName = Username;
            obj.Time = totalTime - countDownTime;
            obj.Rank = levelTitle;
            obj.Miss = tries;
            FormTop3 top3 = new FormTop3(obj);
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            countDownTime--;

            lbTimeLeft.Text = "Time Left: " + countDownTime;

            if (countDownTime < 1)
            {
                
                GameOver("Times Up, You Lose!");

                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("images/" + (string)x.Tag + ".png");
                    }
                }
            }

        }
        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("images/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("images/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                CheckPictures(picA, picB);
            }
        }

        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
