using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Content2
    {
        private const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";
        public Sprite sExplosion;
        public Image iExplosion;
        public Texture tExplosion;

        public Sprite sEnemy;
        public Image iEnemy;
        public Texture tEnemy;

        public void Load()
        {
            #region Animation Explosive Asteroid

            iExplosion = new Image(CONTENT_DIRICTORY + "Explosive\\type_B.png");
            tExplosion = new Texture(iExplosion);
            tExplosion.Smooth = true;
            sExplosion = new Sprite(tExplosion);
            sExplosion.Origin = new Vector2f(iExplosion.Size.X / 2, iExplosion.Size.Y / 2);

            #endregion

            iEnemy = new Image(CONTENT_DIRICTORY + "Enemy\\EnemyShip1_green.png");
            tEnemy = new Texture(iEnemy);
            tEnemy.Smooth = true;
            sEnemy = new Sprite(tEnemy);
            sEnemy.Origin = new Vector2f(iEnemy.Size.X / 2, iEnemy.Size.Y / 2);

            #region Animation Explosive Asteroid



            #endregion
        }


    }
}
