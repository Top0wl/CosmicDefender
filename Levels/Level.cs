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
        public String Name;
        public Boss LevelBoss;

        public bool IsOpen = false;

        public Level()
        {

        }

        public Level(Sprite _Background, Boss _boss, String _Name)
        {
            Background = _Background;
            LevelBoss = _boss;
            Name = _Name;
        }

        public void Settings(Sprite _Background, Boss _boss)
        {
            Background = _Background;
            LevelBoss = _boss;
        }

    }
}
