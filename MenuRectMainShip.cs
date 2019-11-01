using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class MenuRectMainShip
    {
        public Sprite SpriteShip;
        public MenuRectMainShip()
        {
            SpriteShip = Program.content.GetShip1();
            SpriteShip.Position = new SFML.System.Vector2f(590, 320);
        }
    }
}
