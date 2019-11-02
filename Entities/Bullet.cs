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
        public Animation animation;
        public Bullet(float _X, float _Y, float _Rotation, float _size, float _speed)
        {
            this.Settings(Program.content.GetBullet(),"Bullet", _X, _Y, _Rotation, _size, _speed);
            Vector2i pixelPos = Mouse.GetPosition(Program.Window);                                  //забираем коорд курсора
            Vector2f pos = Program.Window.MapPixelToCoords(pixelPos);                               //переводим их в игровые (уходим от коорд окна
            float dX = pos.X - Ship.GetX();                                                       //вектор , колинеарный прямой, которая пересекает спрайт и курсор
            float dY = pos.Y - Ship.GetY();                                                       //он же, координата y
            float rotation = (float)(((Math.Atan2((double)dY, (double)dX)) * 180 / Math.PI) - 90);  //получаем угол в радианах и переводим его в градусы
            sprite.Rotation = _Rotation;
        }

        public override void Update(float time)
        {
            float _x = GetX();
            float _y = GetY();
            _x += GetDx();
            SetX(_x);
            _y += GetDy();
            SetY(_y);

            if (GetX() > Program.WindowWidth || GetX() < 0 || GetY() > Program.WindowHeight || GetY() < 0) SetHealth(0);

        }
        public override void Draw()
        {
            sprite.Position = new Vector2f(GetX(), GetY());
            Program.Window.Draw(sprite);
        }

    }
}
