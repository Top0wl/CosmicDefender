using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class MenuRectShips
    {
        public Sprite SpriteRect;
        public Sprite SpriteShip;
        public String Name;

        public int Damage;
        public float Speed;
        public float Shoot_speed;
        public int Health;
        public int CountGuns;

        public MenuRectShips()
        {
            
        }
        public MenuRectShips(Sprite _SpriteRect, Sprite _SpriteShip, String _Name, Vector2f _Position, int damage, float speed, float shoot_speed, int health, int countguns)
        {
            SpriteRect = _SpriteRect;
            SpriteShip = _SpriteShip;
            SpriteShip.Origin = new Vector2f(_SpriteShip.Texture.Size.X/2, _SpriteShip.Texture.Size.Y/2);
            Name = _Name;
            SpriteRect.Position = _Position;
            Damage = damage;
            Speed = speed;
            Shoot_speed = shoot_speed;
            Health = health;
            CountGuns = countguns;

        }

        public MenuRectShips(Sprite _SpriteRect, String _Name, Vector2f _Position)
        {
            SpriteRect = _SpriteRect;
            Name = _Name;
            SpriteRect.Position = _Position;
        }


    }
}
