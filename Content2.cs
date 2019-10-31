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
        private Sprite sShip1_lock;
        private Sprite sShip2_lock;
        private Sprite sShip3_lock;
        private Sprite sShip4_lock;
        private Sprite sShip5_lock;
        private Sprite sShip6_lock;
        private Sprite sShip7_lock;
        private Sprite sShip8_lock;
        private Sprite sShip9_lock;
        private Sprite sShip1_unlock;
        private Sprite sShip2_unlock;
        private Sprite sShip3_unlock;
        private Sprite sShip4_unlock;
        private Sprite sShip5_unlock;
        private Sprite sShip6_unlock;
        private Sprite sShip7_unlock;
        private Sprite sShip8_unlock;
        private Sprite sShip9_unlock;



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
        private Texture tShip1_lock;
        private Texture tShip2_lock;
        private Texture tShip3_lock;
        private Texture tShip4_lock;
        private Texture tShip5_lock;
        private Texture tShip6_lock;
        private Texture tShip7_lock;
        private Texture tShip8_lock;
        private Texture tShip9_lock;
        private Texture tShip1_unlock;
        private Texture tShip2_unlock;
        private Texture tShip3_unlock;
        private Texture tShip4_unlock;
        private Texture tShip5_unlock;
        private Texture tShip6_unlock;
        private Texture tShip7_unlock;
        private Texture tShip8_unlock;
        private Texture tShip9_unlock;


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
        private Image iShip1_lock;
        private Image iShip2_lock;
        private Image iShip3_lock;
        private Image iShip4_lock;
        private Image iShip5_lock;
        private Image iShip6_lock;
        private Image iShip7_lock;
        private Image iShip8_lock;
        private Image iShip9_lock;
        private Image iShip1_unlock;
        private Image iShip2_unlock;
        private Image iShip3_unlock;
        private Image iShip4_unlock;
        private Image iShip5_unlock;
        private Image iShip6_unlock;
        private Image iShip7_unlock;
        private Image iShip8_unlock;
        private Image iShip9_unlock;



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

            #region Ship1_lock

            iShip1_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship1_lock.png");
            tShip1_lock = new Texture(iShip1_lock);
            tShip1_lock.Smooth = true;
            sShip1_lock = new Sprite(tShip1_lock);

            #endregion

            #region Ship2_lock

            iShip2_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship2_lock.png");
            tShip2_lock = new Texture(iShip2_lock);
            tShip2_lock.Smooth = true;
            sShip2_lock = new Sprite(tShip2_lock);

            #endregion

            #region Ship3_lock

            iShip3_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship3_lock.png");
            tShip3_lock = new Texture(iShip3_lock);
            tShip3_lock.Smooth = true;
            sShip3_lock = new Sprite(tShip3_lock);

            #endregion

            #region Ship4_lock

            iShip4_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship4_lock.png");
            tShip4_lock = new Texture(iShip4_lock);
            tShip4_lock.Smooth = true;
            sShip4_lock = new Sprite(tShip4_lock);

            #endregion

            #region Ship5_lock

            iShip5_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship5_lock.png");
            tShip5_lock = new Texture(iShip5_lock);
            tShip5_lock.Smooth = true;
            sShip5_lock = new Sprite(tShip5_lock);

            #endregion

            #region Ship6_lock

            iShip6_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship6_lock.png");
            tShip6_lock = new Texture(iShip6_lock);
            tShip6_lock.Smooth = true;
            sShip6_lock = new Sprite(tShip6_lock);

            #endregion

            #region Ship7_lock

            iShip7_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship7_lock.png");
            tShip7_lock = new Texture(iShip7_lock);
            tShip7_lock.Smooth = true;
            sShip7_lock = new Sprite(tShip7_lock);

            #endregion

            #region Ship8_lock

            iShip8_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship8_lock.png");
            tShip8_lock = new Texture(iShip8_lock);
            tShip8_lock.Smooth = true;
            sShip8_lock = new Sprite(tShip8_lock);

            #endregion

            #region Ship9_lock

            iShip9_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship9_lock.png");
            tShip9_lock = new Texture(iShip9_lock);
            tShip9_lock.Smooth = true;
            sShip9_lock = new Sprite(tShip9_lock);

            #endregion

            #region Ship1_unlock

            iShip1_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship1_unlock.png");
            tShip1_unlock = new Texture(iShip1_unlock);
            tShip1_unlock.Smooth = true;
            sShip1_unlock = new Sprite(tShip1_unlock);

            #endregion

            #region Ship2_unlock

            iShip2_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship2_unlock.png");
            tShip2_unlock = new Texture(iShip2_unlock);
            tShip2_unlock.Smooth = true;
            sShip2_unlock = new Sprite(tShip2_unlock);

            #endregion

            #region Ship3_unlock

            iShip3_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship3_unlock.png");
            tShip3_unlock = new Texture(iShip3_unlock);
            tShip3_unlock.Smooth = true;
            sShip3_unlock = new Sprite(tShip3_unlock);

            #endregion

            #region Ship4_unlock

            iShip4_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship4_unlock.png");
            tShip4_unlock = new Texture(iShip4_unlock);
            tShip4_unlock.Smooth = true;
            sShip4_unlock = new Sprite(tShip4_unlock);

            #endregion

            #region Ship5_unlock

            iShip5_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship5_unlock.png");
            tShip5_unlock = new Texture(iShip5_unlock);
            tShip5_unlock.Smooth = true;
            sShip5_unlock = new Sprite(tShip5_unlock);

            #endregion

            #region Ship6_unlock

            iShip6_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship6_unlock.png");
            tShip6_unlock = new Texture(iShip6_unlock);
            tShip6_unlock.Smooth = true;
            sShip6_unlock = new Sprite(tShip6_unlock);

            #endregion

            #region Ship7_unlock

            iShip7_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship7_unlock.png");
            tShip7_unlock = new Texture(iShip7_unlock);
            tShip7_unlock.Smooth = true;
            sShip7_unlock = new Sprite(tShip7_unlock);

            #endregion

            #region Ship8_unlock

            iShip8_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship8_unlock.png");
            tShip8_unlock = new Texture(iShip8_unlock);
            tShip8_unlock.Smooth = true;
            sShip8_unlock = new Sprite(tShip8_unlock);

            #endregion

            #region Ship9_unlock

            iShip9_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship9_unlock.png");
            tShip9_unlock = new Texture(iShip9_unlock);
            tShip9_unlock.Smooth = true;
            sShip9_unlock = new Sprite(tShip9_unlock);

            #endregion



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
        public Sprite GetShip1_lock()
        {
            return sShip1_lock;
        }
        public Sprite GetShip2_lock()
        {
            return sShip2_lock;
        }
        public Sprite GetShip3_lock()
        {
            return sShip3_lock;
        }
        public Sprite GetShip4_lock()
        {
            return sShip4_lock;
        }
        public Sprite GetShip5_lock()
        {
            return sShip5_lock;
        }
        public Sprite GetShip6_lock()
        {
            return sShip6_lock;
        }
        public Sprite GetShip7_lock()
        {
            return sShip7_lock;
        }
        public Sprite GetShip8_lock()
        {
            return sShip8_lock;
        }
        public Sprite GetShip9_lock()
        {
            return sShip9_lock;
        }
        public Sprite GetShip1_unlock()
        {
            return sShip1_unlock;
        }
        public Sprite GetShip2_unlock()
        {
            return sShip2_unlock;
        }
        public Sprite GetShip3_unlock()
        {
            return sShip3_unlock;
        }
        public Sprite GetShip4_unlock()
        {
            return sShip4_unlock;
        }
        public Sprite GetShip5_unlock()
        {
            return sShip5_unlock;
        }
        public Sprite GetShip6_unlock()
        {
            return sShip6_unlock;
        }
        public Sprite GetShip7_unlock()
        {
            return sShip7_unlock;
        }
        public Sprite GetShip8_unlock()
        {
            return sShip8_unlock;
        }
        public Sprite GetShip9_unlock()
        {
            return sShip9_unlock;
        }


        #endregion


    }
}
