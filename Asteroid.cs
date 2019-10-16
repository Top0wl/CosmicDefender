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
            int a1 = rdn.Next(1, Program.WindowWidth);
            int a2 = rdn.Next(1, Program.WindowHeight);
            int a3 = rdn.Next(1, 360);
            float speed = (rdn.Next(10,100));
            speed = speed / 100;
            Settings("Asteroid1.png", "Asteroid", a1, a2, a3, 0.4F, speed);
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
            sprite.Position = new Vector2f(GetX(), GetY());
            Program.Window.Draw(sprite);
        }
    }
}
