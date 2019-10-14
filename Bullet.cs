using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Bullet: Entity
    {
        private const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";
        private float speed = 4f;
        public static Sprite sprite;
        private Texture texture;
        private float rot;
        public Bullet(string file, float w, float h)
        {
            texture = new Texture(CONTENT_DIRICTORY + file);
            texture.Smooth = true;
            sprite = new Sprite(texture);
            sprite.Scale = new Vector2f(0.3F, 0.3F);
            sprite.Origin = new Vector2f(w / 2, h / 2);
            //sprite.Rotation = 0;
            SetName("Bullet");
            Vector2i pixelPos = Mouse.GetPosition(Program.Window);//забираем коорд курсора
            Vector2f pos = Program.Window.MapPixelToCoords(pixelPos);//переводим их в игровые (уходим от коорд окна
            float dX = pos.X - Player.GetX();//вектор , колинеарный прямой, которая пересекает спрайт и курсор
            float dY = pos.Y - Player.GetY();//он же, координата y
            float rotation = (float)(((Math.Atan2((double)dY, (double)dX)) * 180 / Math.PI) - 90);//получаем угол в радианах и переводим его в градусы
            rot = rotation;
            sprite.Rotation = rotation;
            float distance = (float)Math.Sqrt(((pos.X - GetX()) * (pos.X - GetX()) + (pos.Y - GetY()) * (pos.Y - GetY())));

            float deltaX = (float)Math.Cos(Math.PI * (rotation-90) / 180.0f)  * -1 * 0.5f;
            float deltaY = (float)Math.Sin(Math.PI * (rotation-90) / 180.0f)  * -1 * 0.5f;

            SetDx(deltaX);
            SetDy(deltaY);
        }

        public override void Update()
        {
            sprite.Rotation = rot;
            float _x = GetX();
            float _y = GetY();
            _x += GetDx();
            SetX(_x);
            _y += GetDy();
            SetY(_y);

            if (GetX() > Program.WindowWidth || GetX() < 0 || GetY() > Program.WindowHeight || GetY() < 0) SetLife(false);

           // if (Mouse.IsButtonPressed(Mouse.Button.Left))
           // {
           //     Bullet b = new Bullet("Bullet.png");
           //     b.Settings(sprite,GetX(),GetY(),GetRotation(),10);
           //     Program.entities.Add(b);
           // }

        }
        public override void Draw()
        {
            sprite.Position = new Vector2f(GetX(), GetY());
            Program.Window.Draw(Bullet.sprite);
        }

    }
}
