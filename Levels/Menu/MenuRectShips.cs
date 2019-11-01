using SFML.Graphics;
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

        public MenuRectShips(Sprite _SpriteRect, Sprite _SpriteShip, String _Name)
        {
            SpriteRect = _SpriteRect;
            SpriteShip = _SpriteShip;
            Name = _Name;
        }
    }
}
