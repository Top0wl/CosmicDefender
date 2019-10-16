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
        //public static Sprite sprite;
        private Texture texture;
        private float rot;
        
        public Bullet()
        {
            this.Settings("Bullet.png","Bullet", Player.GetX(), Player.GetY(), Player.GetRotation(), 0.2F, 20f);
            Vector2i pixelPos = Mouse.GetPosition(Program.Window);                                  //забираем коорд курсора
            Vector2f pos = Program.Window.MapPixelToCoords(pixelPos);                               //переводим их в игровые (уходим от коорд окна
            float dX = pos.X - Player.GetX();                                                       //вектор , колинеарный прямой, которая пересекает спрайт и курсор
            float dY = pos.Y - Player.GetY();                                                       //он же, координата y
            float rotation = (float)(((Math.Atan2((double)dY, (double)dX)) * 180 / Math.PI) - 90);  //получаем угол в радианах и переводим его в градусы
            sprite.Rotation = rotation;
        }

        public override void Update(float time)
        {
            float _x = GetX();
            float _y = GetY();
            _x += GetDx();
            SetX(_x);
            _y += GetDy();
            SetY(_y);

            if (GetX() > Program.WindowWidth || GetX() < 0 || GetY() > Program.WindowHeight || GetY() < 0) SetLife(false);

        }
        public override void Draw()
        {
            sprite.Position = new Vector2f(GetX(), GetY());
            Program.Window.Draw(sprite);
        }

    }
}
