using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Game
    {
        public void CreateParticles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Particle a = new Particle();
                Program.entities.Add(a);
            }
        }
    }
}
