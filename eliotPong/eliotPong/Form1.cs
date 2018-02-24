using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eliotPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics gfx;
        bouncyball pongBall;
        bouncePaddles paddleLeft;
        bouncePaddles paddleRight;
        Random paddleMovement;
        
        int x = 200;
        int LpaddleSpeed = 10;
        int RpaddleSpeed = 10;
        int y = 200;
        int w;
        int h;
        int paddleMotion;
        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bitmap);

            pongBall = new bouncyball(Brushes.DarkGoldenrod, 40, 40, 40, 40, 4, 5);
            paddleLeft = new bouncePaddles(Brushes.Red, 50, 400, 20, 120, LpaddleSpeed);
            paddleRight = new bouncePaddles(Brushes.Beige, ClientSize.Width - 100, 400, 20, 120, RpaddleSpeed);
            paddleMovement = new Random();
            
        }

        private void animeTimer_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            gfx.DrawImage(Properties.Resources.p0Ng, 0, 0, pictureBox1.Width, pictureBox1.Height);
            pongBall.Move();
           

            if (pongBall.HitBox.X + pongBall.HitBox.Width >= ClientSize.Width)
            {
                pongBall.xSpeed *= -1;
            }
            if (pongBall.HitBox.Y + pongBall.HitBox.Height >= ClientSize.Height)
            {
                pongBall.ySpeed *= -1;
            }
            if (pongBall.HitBox.X <= 0)
            {
                pongBall.xSpeed *= -1;
            }
            if (pongBall.HitBox.Y <= 0)
            {
                pongBall.ySpeed *= -1;
            }
            if (paddleLeft.movingUp)
            {
                if (paddleLeft.Y > 0)
                {
                    paddleLeft.Y -= paddleLeft.paddleSpeed;
                }
            }
            else if (paddleLeft.movingDown)
            {
                if(paddleLeft.Y + paddleLeft.H <= ClientSize.Height)
                    {
                    paddleLeft.Y += paddleLeft.paddleSpeed;
                }
            }

            if(pongBall.HitBox.IntersectsWith(paddleLeft.HitBox))
            {
                pongBall.xSpeed *= -1;
            }
            if (pongBall.HitBox.IntersectsWith(paddleRight.HitBox))
            {
                pongBall.xSpeed *= -1;
            }
            
            if (paddleRight.Y + paddleRight.H >= ClientSize.Height)
            {
                // this goes negative.
                paddleRight.paddleSpeed2 *= -1;
            }
            else if (paddleRight.Y < 0)
            {
                //this goes positive.
                paddleRight.paddleSpeed2 *= -1;
            }
                paddleRight.Y = pongBall.y;
           
            // paddleRight.PosCheck(ClientSize);
            paddleRight.Y += paddleRight.paddleSpeed2 + paddleMotion;
            
            //paddleRight.HitBox.Y += paddleRight.paddleSpeed;


            pongBall.Draw(gfx);
            paddleLeft.Draw(gfx);
            paddleRight.Draw(gfx);
            pictureBox1.Image = bitmap;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                paddleLeft.movingUp = true;
                paddleLeft.movingDown = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                paddleLeft.movingDown = true;
                paddleLeft.movingUp = false;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                paddleLeft.movingUp = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                paddleLeft.movingDown = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AITimer_Tick(object sender, EventArgs e)
        {
            paddleMotion = paddleMovement.Next(0, 400) - 200;
            
        }
    }
}
