using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Asteroid : Entity
    {
        private const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";
        private float w, h;
       // public static Sprite sprite;
        private Texture texture;
        private float rotation;
        private String File;

        Random rdn = new Random(DateTime.Now.Millisecond);

        public Asteroid()
        {
            int Choose1, Choose2, a1, a2;
            Choose1 = rdn.Next(0, 1);
            if (Choose1 == 1)
            {
                a1 = rdn.Next(1, Program.WindowWidth);
                Choose2 = rdn.Next(0, 1);
                if (Choose2 == 1)                       //Если 1 то сверху
                {
                    a2 = 0;
                }
                else                                    //Если 2 то снизу
                {
                    a2 = Program.WindowHeight;
                }
            }
            else
            {
                a2 = rdn.Next(1, Program.WindowHeight);
                Choose2 = rdn.Next(0, 1);
                if (Choose2 == 1)                       //Если 1 то слева
                {
                    a1 = 0;
                }
                else                                    //Если 2 то справа
                {
                    a1 = Program.WindowWidth;
                }
            }
            int a3 = rdn.Next(1, 360);
            float speed = (rdn.Next(10,100));
            speed = speed / 100;
            Settings(Content.animAsteroid, "Asteroid", a1, a2, a3, 0.4F, speed);
        }


        public override void Update(float time)
        {
            float _x = GetX();
            float _y = GetY();

            _x += GetDx();
            SetX(_x);
            _y += GetDy();
            SetY(_y);

            if (GetX() > Program.WindowWidth) SetX(0);
            if (GetX() < 0) SetX(Program.WindowWidth);
            if (GetY() > Program.WindowHeight) SetY(0);
            if (GetY() < 0) SetY(Program.WindowHeight);
        }
        public override void Draw()
        {
            animation.sprite.Position = new Vector2f(GetX(), GetY());
            Program.Window.Draw(animation.sprite);
        }
    }
}
