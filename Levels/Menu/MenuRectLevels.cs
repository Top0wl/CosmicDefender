using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class MenuRectLevels : MenuRectShips
    {
        public Sprite Background;

        public MenuRectLevels(Sprite _SpriteRect, String _Name, Vector2f _Position)
        {
            SpriteRect = _SpriteRect;
            Name = _Name;
            SpriteRect.Position = _Position;
        }

        public MenuRectLevels(Sprite _SpriteRect, String _Name, Vector2f _Position, Sprite _Background)
        {
            SpriteRect = _SpriteRect;
            Name = _Name;
            SpriteRect.Position = _Position;
            Background = _Background;
        }

    }
}
