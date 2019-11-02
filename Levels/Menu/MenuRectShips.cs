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

        public MenuRectShips(Sprite _SpriteRect, Sprite _SpriteShip, String _Name, Vector2f _Position)
        {
            SpriteRect = _SpriteRect;
            SpriteShip = _SpriteShip;
            SpriteShip.Origin = new Vector2f(_SpriteShip.Texture.Size.X/2, _SpriteShip.Texture.Size.Y/2);
            Name = _Name;
            SpriteRect.Position = _Position;
        }

        public MenuRectShips(Sprite _SpriteRect, String _Name, Vector2f _Position)
        {
            SpriteRect = _SpriteRect;
            Name = _Name;
            SpriteRect.Position = _Position;
        }
    }
}
