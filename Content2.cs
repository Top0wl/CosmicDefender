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
        private Sprite sExplosion;
        private Sprite sBackground;
        private Sprite cursorSprite;
        private Sprite sAsteroid1;
        private Sprite sAsteroid2;
        private Sprite sEnemy;
        private Sprite sBullet;
        private Sprite sShip1;
        private Sprite sShip2;
        private Sprite sShip3;
        private Sprite sShip4;
        private Sprite sShip5;
        private Sprite sShip6;
        private Sprite sShip7;
        private Sprite sShip8;
        private Sprite sShip9;
        private Sprite sTypeA;
        private Sprite sTypeB;
        private Sprite sTypeC;
        private Sprite sMenu;
        private Sprite sMenuTextBar1;

        private Texture tExplosion;
        private Texture tLevel1;
        private Texture tAsteroid2;
        private Texture tAsteroid1;
        private Texture tCursor;
        private Texture tEnemy;
        private Texture tBullet;
        private Texture tShip1;
        private Texture tShip2;
        private Texture tShip3;
        private Texture tShip4;
        private Texture tShip5;
        private Texture tShip6;
        private Texture tShip7;
        private Texture tShip8;
        private Texture tShip9;
        private Texture tTypeA;
        private Texture tTypeB;
        private Texture tTypeC;
        private Texture tMenu;
        private Texture tMenuTextBar1;

        private Image iEnemy;
        private Image iExplosion;
        private Image iAsteroid2;
        private Image iAsteroid1;
        private Image iLevel1;
        private Image iBullet;
        private Image iShip1;
        private Image iShip2;
        private Image iShip3;
        private Image iShip4;
        private Image iShip5;
        private Image iShip6;
        private Image iShip7;
        private Image iShip8;
        private Image iShip9;
        private Image iTypeA;
        private Image iTypeB;
        private Image iTypeC;
        private Image iMenu;
        private Image iMenuTextBar1;

        public void Load()
        {
            #region Animation Explosive Asteroid

            iExplosion = new Image(CONTENT_DIRICTORY + "Explosive\\type_B.png");
            tExplosion = new Texture(iExplosion);
            tExplosion.Smooth = true;
            sExplosion = new Sprite(tExplosion);
            sExplosion.Origin = new Vector2f(iExplosion.Size.X / 2, iExplosion.Size.Y / 2);

            #endregion

            #region Enemy Ship
            iEnemy = new Image(CONTENT_DIRICTORY + "Enemy\\EnemyShip1_green.png");
            tEnemy = new Texture(iEnemy);
            tEnemy.Smooth = true;
            sEnemy = new Sprite(tEnemy);
            sEnemy.Origin = new Vector2f(iEnemy.Size.X / 2, iEnemy.Size.Y / 2);
            #endregion

            #region Level
            iLevel1 = new Image(CONTENT_DIRICTORY + "Level1.jpg");
            tLevel1 = new Texture(iLevel1);
            tLevel1.Smooth = true;
            sBackground = new Sprite(tLevel1);
            cursorSprite = new Sprite(tCursor);
            #endregion

            #region Asteroid1
            iAsteroid1 = new Image(CONTENT_DIRICTORY + "animAsteroid.png");
            tAsteroid1 = new Texture(iAsteroid1);
            tAsteroid1.Smooth = true;
            sAsteroid1 = new Sprite(tAsteroid1);
            #endregion

            #region Asteroid2
            iAsteroid2 = new Image(CONTENT_DIRICTORY + "animAsteroid2.png");
            tAsteroid2 = new Texture(iAsteroid2);
            tAsteroid2.Smooth = true;
            sAsteroid2 = new Sprite(tAsteroid2);
            #endregion

            #region Bullet

            iBullet = new Image(CONTENT_DIRICTORY + "Bullet.png");
            tBullet = new Texture(iBullet);
            tBullet.Smooth = true;
            sBullet = new Sprite(tBullet);

            #endregion

            #region TypeA
            iTypeA = new Image(CONTENT_DIRICTORY + "Explosive\\type_A.png");
            tTypeA = new Texture(iTypeA);
            tTypeA.Smooth = true;
            sTypeA = new Sprite(tTypeA);

            #endregion

            #region TypeB
            iTypeB = new Image(CONTENT_DIRICTORY + "Explosive\\type_B.png");
            tTypeB = new Texture(iTypeB);
            tTypeB.Smooth = true;
            sTypeB = new Sprite(tTypeB);

            #endregion

            #region TypeC
            iTypeC = new Image(CONTENT_DIRICTORY + "Explosive\\type_C.png");
            tTypeC = new Texture(iTypeC);
            tTypeC.Smooth = true;
            sTypeC = new Sprite(tTypeC);

            #endregion

            #region Ship1

            iShip1 = new Image(CONTENT_DIRICTORY + "Ships\\Ship1.png");
            tShip1 = new Texture(iShip1);
            tShip1.Smooth = true;
            sShip1 = new Sprite(tShip1);

            #endregion

            #region Ship2

            iShip2 = new Image(CONTENT_DIRICTORY + "Ships\\Ship2.png");
            tShip2 = new Texture(iShip2);
            tShip2.Smooth = true;
            sShip2 = new Sprite(tShip2);

            #endregion

            #region Ship3

            iShip3 = new Image(CONTENT_DIRICTORY + "Ships\\Ship3.png");
            tShip3 = new Texture(iShip3);
            tShip3.Smooth = true;
            sShip3 = new Sprite(tShip3);

            #endregion

            #region Ship4

            iShip4 = new Image(CONTENT_DIRICTORY + "Ships\\Ship4.png");
            tShip4 = new Texture(iShip4);
            tShip4.Smooth = true;
            sShip4 = new Sprite(tShip4);

            #endregion

            #region Ship5

            iShip5 = new Image(CONTENT_DIRICTORY + "Ships\\Ship5.png");
            tShip5 = new Texture(iShip5);
            tShip5.Smooth = true;
            sShip5 = new Sprite(tShip5);

            #endregion

            #region Ship6

            iShip6 = new Image(CONTENT_DIRICTORY + "Ships\\Ship6.png");
            tShip6 = new Texture(iShip6);
            tShip6.Smooth = true;
            sShip6 = new Sprite(tShip6);

            #endregion

            #region Ship7

            iShip7 = new Image(CONTENT_DIRICTORY + "Ships\\Ship7.png");
            tShip7 = new Texture(iShip7);
            tShip7.Smooth = true;
            sShip7 = new Sprite(tShip7);

            #endregion

            #region Ship8

            iShip8 = new Image(CONTENT_DIRICTORY + "Ships\\Ship8.png");
            tShip8 = new Texture(iShip8);
            tShip8.Smooth = true;
            sShip8 = new Sprite(tShip8);

            #endregion

            #region Ship9

            iShip9 = new Image(CONTENT_DIRICTORY + "Ships\\Ship9.png");
            tShip9 = new Texture(iShip9);
            tShip9.Smooth = true;
            sShip9 = new Sprite(tShip9);

            #endregion

            #region Menu

            iMenu = new Image(CONTENT_DIRICTORY + "Levels\\Menu.png");
            tMenu = new Texture(iMenu);
            tMenu.Smooth = true;
            sMenu = new Sprite(tMenu);
            sMenu.Scale = new Vector2f(0.7F, 0.7F);
            sMenu.Position = new Vector2f(270F, 0F);

            iMenuTextBar1 = new Image(CONTENT_DIRICTORY + "Levels\\Menu\\TextBar1.png");
            tMenuTextBar1 = new Texture(iMenuTextBar1);
            tMenuTextBar1.Smooth = true;
            sMenuTextBar1 = new Sprite(tMenuTextBar1);
            sMenuTextBar1.Scale = new Vector2f(0.7F, 1.5F);
            sMenuTextBar1.Position = new Vector2f(270, 0);



            #endregion  //Хуета



        }
        #region Getters

        public Sprite GetsExplosion()
        {
            return sExplosion;
        }

        public Sprite GetsEnemy()
        {
            return sEnemy;
        }

        public Sprite GetLevel1()
        {
            return sBackground;
        }

        public Sprite GetAsteroid1()
        {
            return sAsteroid1;
        }

        public Sprite GetAsteroid2()
        {
            return sAsteroid2;
        }

        public Sprite GetBullet()
        {
            return sBullet;
        }

        public Sprite GetTypeA()
        {
            return sTypeA;
        }

        public Sprite GetTypeB()
        {
            return sTypeB;
        }

        public Sprite GetTypeC()
        {
            return sTypeC;
        }


        public Sprite GetShip1()
        {
            return sShip1;
        }

        public Sprite GetShip2()
        {
            return sShip2;
        }

        public Sprite GetShip3()
        {
            return sShip3;
        }

        public Sprite GetShip4()
        {
            return sShip4;
        }

        public Sprite GetShip5()
        {
            return sShip5;
        }

        public Sprite GetShip6()
        {
            return sShip6;
        }

        public Sprite GetShip7()
        {
            return sShip7;
        }

        public Sprite GetShip8()
        {
            return sShip8;
        }

        public Sprite GetShip9()
        {
            return sShip9;
        }

        public Sprite GetMenu()
        {
            return sMenu;
        }
        public Sprite GetMenuTextBar1()
        {
            return sMenuTextBar1;
        }

        #endregion


    }
}
