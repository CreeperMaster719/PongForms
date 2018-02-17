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
    class bouncyball
    {


        public int x;
        public int xSpeed;
        public int y;
        public int ySpeed;
        public int width;
        public int height;
        public Rectangle HitBox;



        Brush color;
        public bouncyball(Brush color, int x, int y, int w, int h, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            width = w;
            height = h;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
            this.color = color;
            HitBox = new Rectangle(x, y, w, h);
        }
        public void Move()
        {
            HitBox.X += xSpeed;
            HitBox.Y += ySpeed;
        }



        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(color, HitBox);
           
        }        
    }
}
