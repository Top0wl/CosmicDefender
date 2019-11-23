using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Constants
    {
        public Boss Boss1;
        Animation AnimationBoss1;

        public Constants()
        {
            AnimationBoss1 = new Animation(Program.content.GetBoss1(), 0, 0, 338, 338, 3, 0.02f);
            Boss1 = new Boss(Program.content.GetBoss1(), AnimationBoss1, 0, 0, 0, 0.3f, 0, 10000, 0, "Boss1");
        }
    }
}
