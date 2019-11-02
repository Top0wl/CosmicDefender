using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class MenuRectButtons
    {
        public Sprite SpriteRect;
        public String Name;

        public MenuRectButtons(Sprite _SpriteRect, String _Name, Vector2f _Position)
        {
            SpriteRect = _SpriteRect;
            Name = _Name;
            SpriteRect.Position = _Position;
        }
    }
}
