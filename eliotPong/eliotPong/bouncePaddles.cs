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
        public Rectangle HitBox;
       public int paddleSpeed = 10;

        public bouncePaddles(Brush color, int X, int Y, int W, int H, int Speed)
        {
            this.X = X;
            this.Y = Y;
            this.W = W;
            this.H = H;
            this.Speed = Speed;
            this.color = color;
            HitBox = new Rectangle(X, Y, W, H);
        }
       public void PosCheck(Size ClientSize)
        {
            if (HitBox.Y <= ClientSize.Height + 60)
            {
                paddleSpeed *= -1;
            }
            else if (HitBox.Y + HitBox.Height >= 0)
            {
                paddleSpeed *= -1;
            }
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, HitBox);
        }

    }
}
