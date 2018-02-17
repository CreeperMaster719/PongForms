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
        int x = 200;
        int pX;
        int pY;
        int pW;
        int pH;
        int LpaddleSpeed = 10;
        int RpaddleSpeed = 10;


        int y = 200;

        int w;
        int h;
        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bitmap);

            pongBall = new bouncyball(Brushes.Black, 40, 40, 40, 40, 4, 5);
            paddleLeft = new bouncePaddles(Brushes.Black, 50, 400, 20, 120, LpaddleSpeed);
            paddleRight = new bouncePaddles(Brushes.Blue, ClientSize.Width - 100, 400, 20, 120, RpaddleSpeed);
        }

        private void animeTimer_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
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
                if (paddleLeft.HitBox.Y > 0)
                {
                    paddleLeft.HitBox.Y -= paddleLeft.paddleSpeed;
                }
            }
            else if (paddleLeft.movingDown)
            {
                if(paddleLeft.HitBox.Y + paddleLeft.HitBox.Height <= ClientSize.Height)
                    {
                    paddleLeft.HitBox.Y += paddleLeft.paddleSpeed;
                }
            }




            paddleLeft.PosCheck(ClientSize);
            paddleRight.PosCheck(ClientSize);
           
            paddleRight.HitBox.Y += paddleRight.paddleSpeed;


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
            }
            else if (e.KeyCode == Keys.S)
            {
                paddleLeft.movingDown = true;
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
    }
}
