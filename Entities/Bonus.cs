using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace ComicDefender
{
    class Bonus : Entity
    {
        protected int armour;
        protected static Vector2f location = new Vector2f(0, 0);

        public Bonus()
        { 
        }

        public Bonus(Sprite _sprite, float _X, float _Y, string name)
        {
            Name = name;
            sprite = new Sprite(_sprite);
            sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.1F, 0.1F);
            X = _X;
            Y = _Y;
        }
        public override void Update(float time)
        {
            Program.Window.Draw(sprite);
        }

    }
}
