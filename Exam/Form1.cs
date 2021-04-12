using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private const int SEC_MAX = 30;
        private Button[,] bu;
        private int chosen;
        private readonly Timer tmDown = new Timer();
        private int level;
        private DateTime endTimeDown;
        private int seconds;
        private int correct = 0;
        private int wrong = 0;
        private Image[] img;

        public int Rows { get; private set; } = 4;
        public int Cols { get; private set; } = 4;
        public Form1()
        {
            InitializeComponent();
            tmDown.Interval = 100;
            tmDown.Tick += TmDown_Tick;
            endTimeDown = DateTime.Now.AddSeconds(SEC_MAX);
            tmDown.Start();
            level = 1;
            CreateButtons();
            ResizeButtons();


            buIncrease.Click += BuIncrease_Click;
            buDecrease.Click += BuDecrease_Click;
            buStart.Click += BuStart_Click;
        }

        private void TmDown_Tick(object sender, EventArgs e)
        {
            var x = endTimeDown - DateTime.Now;
            if (x.Ticks < 0)
            {
                tmDown.Stop();
                x = TimeSpan.Zero;
                MessageBox.Show($"Игра окончена. Верных ответов: {correct}");
                BuStart_Click(sender, e);
            }
            seconds = x.Seconds;
            laTimer.Text = $"Время: {seconds.ToString().PadLeft(2, '0')}";
        }

        private void BuDecrease_Click(object sender, EventArgs e)
        {
            if (level > 1)
            {
                --level;
                laLevel.Text = $"Уровень {level}";
                Rows--;
                Cols--;
                CreateButtons();
                ResizeButtons();
            }
        }

        private void BuIncrease_Click(object sender, EventArgs e)
        {
            if (level < 4)
            {
                ++level;
                laLevel.Text = $"Уровень {level}";
                Rows++;
                Cols++;
                CreateButtons();
                ResizeButtons();
            }
        }

        private void BuStart_Click(object sender, EventArgs e)
        {
            endTimeDown = DateTime.Now.AddSeconds(SEC_MAX);
            tmDown.Start();
            CreateButtons();
            ResizeButtons();
            wrong = 0;
            correct = 0;
            laIncorrect.Text = $"Неверно: {wrong}";
            laCorrect.Text = $"Верно: {correct}";
        }

        private void ResizeButtons()
        {
            int xCellWidth = px.ClientSize.Width / Cols;
            int xCellHeight = px.ClientSize.Height / Rows;

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    bu[i, j].Width = xCellWidth;
                    bu[i, j].Height = xCellHeight;
                    bu[i, j].Location = new Point(xCellWidth * j, xCellHeight * i);
                }
        }

        private void CreateButtons()
        {
            px.Controls.Clear();
            bu = new Button[Rows, Cols];
            
            bool draw = true;
            img = new Image[] {Properties.Resources.sqr_red,
            Properties.Resources.sqr_yellow, Properties.Resources.blue
            };
            Random rnd = new Random();

            
            chosen = rnd.Next(img.Length);

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    bu[i, j] = new Button();
                    bu[i, j].Tag = null;
                }

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    int index = rnd.Next(img.Length);

                    if (index == chosen)
                    {
                        if (draw)
                        {
                            bu[i, j].Image = img[index];
                            bu[i, j].Tag = index;
                            draw = false;
                        }
                        else
                        {
                            while (index == chosen)
                            {
                            index = rnd.Next(img.Length);
                            }
                            bu[i, j].Image = img[index];
                            bu[i, j].Tag = index;
                        }
                    }
                    else
                    {
                        bu[i, j].Image = img[index];
                    }

                    bu[i, j].Click += Form1_Click; 
                    px.Controls.Add(bu[i, j]);
                }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (Convert.ToInt32(btn.Tag) == chosen)
            {
                correct++;
                laCorrect.Text = $"Верно: {correct}";
            }
            else
            {
                wrong++;
                laIncorrect.Text = $"Неверно: {wrong}";
            }
            CreateButtons();
            ResizeButtons();
        }

    }
}
