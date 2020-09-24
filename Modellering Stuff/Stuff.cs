using System;

namespace Modellering_Stuff
{
    public class Stuff
    {
        private int x = 0;
        private int y = 0;
        private bool moving = false;
        public Stuff(int xvalue, int yvalue, bool m)
        {
            x = xvalue;
            y = yvalue;
            moving = m;
        }
        public int getHealth()
        {
            return x;
        }
        public int getShield()
        {
            return y;
        }
        public bool isMoving()
        {
            return moving;
        }
    }
}
