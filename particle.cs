using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    public class Particle
    {
        public float DY, DX, X, Y, Speed, Angle;
        public float q;
        public int flag;
        public Particle(float angle, float speed, float dx, float dy, float x, float y, float Q, int Flag)
        {
            Angle = angle;
            Speed = speed;
            DX = dx;
            DY = dy;
            X = x;
            Y = y;
            q = Q;
            flag = Flag;
        }
    }
}
