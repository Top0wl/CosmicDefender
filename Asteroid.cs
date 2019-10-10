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
        public static Sprite sprite;
        private Texture texture;
        private float rotation;
        private String File;



        public Asteroid(String F, float W, float H, float speed)
        {
            File = F;
            w = W; h = H;
            texture = new Texture(CONTENT_DIRICTORY + File);
            texture.Smooth = true;
            sprite = new Sprite(texture);
            sprite.Origin = new Vector2f(w / 2, h / 2);
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            Random rnd = new Random();
            
            SetDx((float)rnd.Next(1,5)/speed);
            SetDy((float)rnd.Next(1,5)/speed);
            SetName("Asteroid");
        }


        public override void Update()
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
    }
}
