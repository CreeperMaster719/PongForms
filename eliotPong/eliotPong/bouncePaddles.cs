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
    class bouncePaddles
    {
        public int X;
        public int Y;
        public int W;
        public int H;
        public int Speed;
        Brush color;
        public bool movingUp = false;
        public bool movingDown = false;        

        public Rectangle HitBox
        {
            get
            {
                return new Rectangle(X, Y, W, H);
            }
        }
       public int paddleSpeed = 10;
        public int paddleSpeed2 = 5;

        public bouncePaddles(Brush color, int X, int Y, int W, int H, int Speed)
        {
            this.X = X;
            this.Y = Y;
            this.W = W;
            this.H = H;
            this.Speed = Speed;
            this.color = color;
        }
        public void PosCheck(Size ClientSize)
        {
            Y += Speed;

            if (Y + H >= ClientSize.Height)
            {
                // this goes negative.
                Speed *= -1;
            }
            else if (Y < 0)
            {
                //this goes positive.
                Speed *= -1;
            }
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, HitBox);
        }

    }
}
