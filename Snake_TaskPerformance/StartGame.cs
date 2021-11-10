using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_TaskPerformance
{
    public partial class StartGame : MaterialSkin.Controls.MaterialForm
    {
        
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private SpecialCircle specialFood= new SpecialCircle();

        public StartGame()
        {
            InitializeComponent();
            new GameSettings();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / GameSettings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            GameStart();

        }

        private void GameStart()
        {
            new GameSettings();

            Snake.Clear();
            Circle head = new Circle {X = 10, Y = 5 };
            Snake.Add(head);

            lblScore.Text = GameSettings.Score.ToString();
            Generatefood();
        }

        private void Generatefood()
        {

            int horizontalPos = pbCanvas.Size.Width / GameSettings.Width;
            int verticalPos = pbCanvas.Size.Height / GameSettings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, horizontalPos), Y = random.Next(0, verticalPos) };

            if (GameSettings.Score % 5 == 0 && GameSettings.Score > 0)
            {
                specialFood = new SpecialCircle { A = random.Next(0, horizontalPos - 1), B = random.Next(0, verticalPos - 1) };
            }

        }

        private void GenerateSpecialFood()
        {
            int horizontalPos = (pbCanvas.Size.Width - 1)/ (GameSettings.Width - 1);
            int verticalPos = (pbCanvas.Size.Height - 1)/ (GameSettings.Height - 1);

            Random random = new Random();
            specialFood = new SpecialCircle { A = random.Next(0, horizontalPos - 1), B = random.Next(0, verticalPos - 1) };
            
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (GameSettings.Gameover == true)
            {
                //Check if Enter is pressed

                if (Input.KeyPressed(Keys.Enter))
                {
                    GameStart();
                }

            }
            else
            {

                if (Input.KeyPressed(Keys.Right) && GameSettings.direction != Direction.Left)
                    GameSettings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && GameSettings.direction != Direction.Right)
                    GameSettings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && GameSettings.direction != Direction.Down)
                    GameSettings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && GameSettings.direction != Direction.Up)
                    GameSettings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics pcanvas = e.Graphics;
            
            if (GameSettings.Gameover != true) {

                for (int i = 0; i < Snake.Count; i++)
                {

                    Brush snakeColor;
                    //draw head
                    if (i == 0)
                    {
                        //head
                        snakeColor = GameSettings.snakeHead;
                    }
                    else
                    {
                        //body
                        snakeColor = GameSettings.snakeBody;
                    }
                    //draw snake
                    pcanvas.FillEllipse(snakeColor, 

                        new Rectangle(Snake[i].X * GameSettings.Width,
                        Snake[i].Y * GameSettings.Height,
                        GameSettings.Width, GameSettings.Height
                        
                        ));

                    pcanvas.FillEllipse(Brushes.LightGreen, 

                        new Rectangle(food.X * GameSettings.Width,
                        food.Y * GameSettings.Height, GameSettings.Width,
                        GameSettings.Height

                        ));

                    if (GameSettings.Score % 5 == 0 && GameSettings.Score > 0)
                    {
                        pcanvas.FillEllipse(Brushes.Gold,
                         new Rectangle(specialFood.A * GameSettings.Width,
                         specialFood.B * GameSettings.Height, GameSettings.Width,
                         GameSettings.Height
                         ));
                    }

                }

            }
            else
            {

                Close();
                Visible = false;
                GameOver gameOver = new GameOver();
                gameOver.Visible = true;

            }

        }

        public void MovePlayer()
        {
            
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (GameSettings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;

                    }

                    int horizontalPos = pbCanvas.Size.Width / GameSettings.Width;
                    int verticalPos = pbCanvas.Size.Height / GameSettings.Height;
                    
                    //detects collision on borders 
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= horizontalPos || Snake[i].Y >= verticalPos)
                    {
                        Die();
                    }
                    //detects collision with body 
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }
                    //detect food collision 
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                    if (Snake[0].X == specialFood.A && Snake[0].Y == specialFood.B)
                    {
                        EatSpecial();
                    }
                    
                }
                else
                {
                    //Move Body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void EatSpecial()
        {
            GameSettings.Score += 4;
            lblScore.Text = GameSettings.Score.ToString();
        }

        private void Eat()
        {

            //add circle to the body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);
            //update score
            GameSettings.Score += GameSettings.Points;
            GameSettings.Speed += 4;
            lblScore.Text = GameSettings.Score.ToString();
            Generatefood();
        }

        private void Die()
        {
            GameSettings.Gameover = true;
        }

        private void StartGame_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void StartGame_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                gameTimer.Stop();
                DialogResult dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo);
                if (dialog.Equals(DialogResult.Yes))
                {
                    MessageBox.Show("THANK YOU FOR PLAYING!");
                    Environment.Exit(0);
                }
                else if (dialog.Equals(DialogResult.No))
                {
                    gameTimer.Start();
                    return true;
                }
            }
            else if (keyData == (Keys.Space))
            {
                gameTimer.Stop();
                DialogResult res = MessageBox.Show("GAME PAUSED! \nCONTINUE PLAYING?", "PAUSED", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    gameTimer.Start();
                    return true;
                }
                else if (res == DialogResult.No)
                {
                    Close();
                    Visible = false;
                    GameOver gameOver = new GameOver();
                    gameOver.Visible = true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
