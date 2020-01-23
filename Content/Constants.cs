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
        const int X = 500;
        const int Y = 500;


        public Ship Ship1;
        public Ship Ship2;
        public Ship Ship3;
        public Ship Ship4;
        public Ship Ship5;
        public Ship Ship6;
        public Ship Ship7;
        public Ship Ship8;
        public Ship Ship9;


        Animation AnimationBoss1;
        public Boss Boss1;
        public Boss Boss2;
        public Boss Boss3;
        public Boss Boss4;
        public Boss Boss5;
        public Boss Boss6;


        public Constants()
        {
            AnimationBoss1 = new Animation(Program.content.GetBoss1(), 0, 0, 338, 338, 3, 0.02f);
            Boss1 = new Boss(Program.content.GetBoss1(), AnimationBoss1, 0, 0, 0, 0.3f, 0, 10000, 0, "Boss1");
            Boss2 = new Boss(Program.content.GetBoss2(), 0, 0, 0, 0.3f, 0, 10000, 0, "Boss2");
            Boss3 = new Boss(Program.content.GetBoss3(), 0, 0, 0, 0.3f, 0, 10000, 0, "Boss3");
            Boss4 = new Boss(Program.content.GetBoss4(), 0, 0, 0, 0.3f, 0, 10000, 1, "Boss4");
            Boss5 = new Boss(Program.content.GetBoss5(), 0, 0, 0, 0.3f, 0, 10000, 0, "Boss5");
            Boss6 = new Boss(Program.content.GetBoss6(), 0, 0, 0, 0.3f, 0, 10000, 0, "Boss6");



            Ship1 = new Ship(Program.content.GetShip1(), X, Y, 25, 1.5f, .2f, 100, 1);
            Ship2 = new Ship(Program.content.GetShip2(), X, Y, 15, 1.2f, .4f, 100, 2);
            Ship3 = new Ship(Program.content.GetShip3(), X, Y, 40, 1.2f, .15f, 140, 1);
            Ship4 = new Ship(Program.content.GetShip4(), X, Y, 45, 1.4f, .18f, 150, 1);
            Ship5 = new Ship(Program.content.GetShip5(), X, Y, 30, 2f, .25f, 110, 1);
            Ship6 = new Ship(Program.content.GetShip6(), X, Y, 25, 2.2f, .5f, 90, 1);
            Ship7 = new Ship(Program.content.GetShip7(), X, Y, 30, 1.1f, .2f, 200, 2);
            Ship8 = new Ship(Program.content.GetShip8(), X, Y, 35, 1.3f, .24f, 310, 2);
            Ship9 = new Ship(Program.content.GetShip9(), X, Y, 40, 2f, .3f, 400, 2);

        }
    }
}
