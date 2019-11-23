using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Level
    {
        public Sprite Background;
        public Sprite Boss;

        public Boss LevelBoss;

        public bool IsOpen = false;

        public Level()
        {

        }

        public Level(Sprite _Background, Sprite _Boss)
        {
            Background = _Background;
            Boss = _Boss;
            
        }

        public void Settings(Sprite _Background, Sprite _Boss)
        {
            Background = _Background;
            Boss = _Boss;
        }

    }
}
