using Snake2D.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake2D
{
    public partial class Form1 : Form
    {
        static int fieldX = 640, fieldY = 480;
        static int sizeDot = 40;
        Random rand = new Random();

        PictureBox apple = new PictureBox();
        PictureBox[] snake;
        //PictureBox[,] grass;
        int dirX = 1, dirY = 0;
        int score = 0;
        bool gameIsOpen = true;

        public Form1()
        {
            InitializeComponent();

            if (Settings.Default.GameDelay == 0 || Settings.Default.sizeX == 0 || Settings.Default.sizeY == 0)
            {
                SettingsManager.Saver(200, 16, 12);
            }

            fieldX = Settings.Default.sizeX * sizeDot;
            fieldY = Settings.Default.sizeY * sizeDot;
            timerGameDelay.Interval = Settings.Default.GameDelay;

            snake = new PictureBox[fieldX / sizeDot * (fieldY / sizeDot)];
            //grass = new PictureBox[fieldY / sizeDot, fieldX / sizeDot] ;

            GenMap();

            //generating first items

            apple.Location = GenRandPoint();
            apple.Size = new Size(sizeDot, sizeDot);
            //apple.SizeMode = PictureBoxSizeMode.StretchImage;
            apple.Image = Resources.apple;
            //Controls.Remove
            Controls.Add(apple);

            snake[0] = new PictureBox();
            snake[0].Location = GenRandPoint();
            snake[0].Size = new Size(sizeDot, sizeDot);
            //snake[0].SizeMode = PictureBoxSizeMode.StretchImage;
            snake[0].Image = Resources.snake_face;
            Controls.Add(snake[0]);
        }

        private void GenMap()
        {
            /*
            for (int iy = 0; iy < fieldX / sizeDot; iy++)
            {
                for (int ix = 0; ix < fieldY / sizeDot; ix++)
                {
                    int grassID = ix * iy;
                    grass[grassID] = new PictureBox();
                    grass[grassID].Location = new Point(ix * sizeDot, iy * sizeDot);
                    grass[grassID].Size = new Size(sizeDot, sizeDot);
                    grass[grassID].Image = Resources.grass;
                    //grass[grassID].SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(grass[grassID]);
                }
            }
            */

            PictureBox borderX = new PictureBox();
            borderX.BackColor = Color.Black;
            borderX.Location = new Point(0, fieldY);
            borderX.Size = new Size(fieldX, 1);
            Controls.Add(borderX);

            PictureBox borderY = new PictureBox();
            borderY.BackColor = Color.Black;
            borderY.Location = new Point(fieldX, 0);
            borderY.Size = new Size(1, fieldY + 1);
            Controls.Add(borderY);
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            CheckBorders();
            CheckApple();
            MoveSnake();
        }

        private void CheckBorders()
        {
            if (snake[0].Location.X < 0)
            {
                remove();
                dirX = 1;
                dirY = 0;
            }
            if (snake[0].Location.X >= fieldX)
            {
                remove();
                dirX = -1;
                dirY = 0;
            }
            if (snake[0].Location.Y < 0)
            {
                remove();
                dirX = 0;
                dirY = 1;
            }
            if (snake[0].Location.Y >= fieldY)
            {
                remove();
                dirX = 0;
                dirY = -1;
            }
            void remove()
            {
                for (int i = 1; i <= score; i++)
                    Controls.Remove(snake[i]);
                score = 0;
                UpdateScore();
            }
        }

        private void CheckApple()
        {
            if (snake[0].Location == apple.Location)
            {
                score++;
                UpdateScore();

                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + sizeDot * dirX, snake[score - 1].Location.Y + sizeDot * dirY);
                snake[score].Size = new Size(sizeDot, sizeDot);
                snake[score].Image = Resources.snake_tail;
                Controls.Add(snake[score]);

                MoveApple();
            }
            void MoveApple()
            {
                apple.Location = GenRandPoint();
                for (int i = 1; i <= score; i++)
                    if (apple.Location == snake[i].Location) MoveApple();
            }
        }

        private void MoveSnake()
        {
            for (int i = score; i >= 1; i--)
                snake[i].Location = snake[i - 1].Location;
            snake[0].Location = new Point(snake[0].Location.X + dirX * sizeDot, snake[0].Location.Y + dirY * sizeDot);

            for (int i = 1; i < score; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    for (int j = i; j <= score; j++)
                        Controls.Remove(snake[j]);
                    score = i - 1;
                    UpdateScore();
                }
            }
        }

        private void UpdateScore() => labelScore.Text = ProgramResources.score + score.ToString();

        private Point GenRandPoint() => new Point(rand.Next(0, fieldX / sizeDot) * sizeDot, rand.Next(0, fieldY / sizeDot) * sizeDot);

        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                case "D":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                case "A":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                case "W":
                    dirX = 0;
                    dirY = -1;
                    break;
                case "Down":
                case "S":
                    dirX = 0;
                    dirY = 1;
                    break;
                case "Space":
                case "P":
                    if (gameIsOpen)
                        timerGameDelay.Stop();
                    else
                        timerGameDelay.Start();
                    gameIsOpen = !gameIsOpen;
                    break;
                case "E":
                    new FormSettings().Show();
                    break;
            }
        }
    }
}
