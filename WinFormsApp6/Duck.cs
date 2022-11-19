using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    internal class Duck
    {
        public Point position;
        public int speedX, speedY;
        public Duck(int xpos, int ypos, int speedx, int speedy) {
            position = new Point(xpos, ypos);
            speedX = speedx;
            speedY = speedy;
        }
        public void Move() { 
            position.X += speedX;
            position.Y -= speedY;
        }
        public void Paint(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.Black), position.X-30,position.Y-30,60,60);
        }
        public void Shot()
        {
            speedX = 0;
            speedY = -2;
        }
    }
}
