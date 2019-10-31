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
        private Font font;
        private Text TextPlay;
        private RectangleShape RectangleHp1;
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
        private Sprite sMenuLevels;
        private Sprite sMenuShips;
        private Sprite sMenuTable;
        private Sprite sMenuButton;
        private Sprite sCircle1;
        private Sprite sCircle2;
        private Sprite sCircle3;
        private Sprite sCircle4;
        public Sprite[] sMenuRectHp = new Sprite[3];
        public Sprite[] sMenuRectDmg = new Sprite[3];
        public Sprite[] sMenuRectSpd = new Sprite[3];

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
        private Texture tMenuLevels;
        private Texture tMenuShips;
        private Texture tMenuTable;
        private Texture tMenuButton;
        private Texture tCircle1;
        private Texture tCircle2;
        private Texture tCircle3;
        private Texture tCircle4;
        private Texture tMenuRectBlue;
        private Texture tMenuRectRed;


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
        private Image iMenuLevels;
        private Image iMenuShips;
        private Image iMenuTable;
        private Image iMenuButton;
        private Image iCircle1;
        private Image iCircle2;
        private Image iCircle3;
        private Image iCircle4;
        private Image iMenuRectBlue;
        private Image iMenuRectRed;

        public void Load()
        {

            font = new Font(@"..\Content\Textures\Font\eng.ttf");

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


            this.iMenuLevels = new Image(@"..\Content\Textures\Interface\form_levels.png");
            this.tMenuLevels = new Texture(this.iMenuLevels);
            this.tMenuLevels.Smooth = true;
            this.sMenuLevels = new Sprite(this.tMenuLevels);
            this.sMenuLevels.Position = new Vector2f(0f, 0f);
            this.iMenuShips = new Image(@"..\Content\Textures\Interface\form_ships.png");
            this.tMenuShips = new Texture(this.iMenuShips);
            this.tMenuShips.Smooth = true;
            this.sMenuShips = new Sprite(this.tMenuShips);
            this.sMenuShips.Position = new Vector2f(980f, 0f);
            this.iMenuTable = new Image(@"..\Content\Textures\Interface\form_table.png");
            this.tMenuTable = new Texture(this.iMenuTable);
            this.tMenuTable.Smooth = true;
            this.sMenuTable = new Sprite(this.tMenuTable);
            this.sMenuTable.Position = new Vector2f(540f, 280f);
            this.iCircle1 = new Image(@"..\Content\Textures\Interface\circle1.png");
            this.iCircle2 = new Image(@"..\Content\Textures\Interface\circle2.png");
            this.iCircle3 = new Image(@"..\Content\Textures\Interface\circle3.png");
            this.iCircle4 = new Image(@"..\Content\Textures\Interface\circle4.png");
            this.tCircle1 = new Texture(this.iCircle1);
            this.tCircle2 = new Texture(this.iCircle2);
            this.tCircle3 = new Texture(this.iCircle3);
            this.tCircle4 = new Texture(this.iCircle4);
            this.tCircle1.Smooth = true;
            this.tCircle2.Smooth = true;
            this.tCircle3.Smooth = true;
            this.tCircle4.Smooth = true;
            this.sCircle1 = new Sprite(this.tCircle1);
            this.sCircle2 = new Sprite(this.tCircle2);
            this.sCircle3 = new Sprite(this.tCircle3);
            this.sCircle4 = new Sprite(this.tCircle4);
            this.sCircle1.Position = new Vector2f(740f, 200f);
            this.sCircle2.Position = new Vector2f(740f, 450f);
            this.sCircle3.Position = new Vector2f(470f, 450f);
            this.sCircle4.Position = new Vector2f(470f, 200f);
            this.iMenuButton = new Image(@"..\Content\Textures\Interface\form_play.png");
            this.tMenuButton = new Texture(this.iMenuButton);
            this.tMenuButton.Smooth = true;
            this.sMenuButton = new Sprite(this.tMenuButton);
            this.sMenuButton.Position = (new Vector2f(560f, 600f));
            this.TextPlay = new Text();
            this.TextPlay.Font = this.font;
            this.TextPlay.DisplayedString = "Play";
            this.TextPlay.CharacterSize = 18;
            this.TextPlay.FillColor = Color.Red;
            this.TextPlay.Style = Text.Styles.Bold;
            this.TextPlay.Position = new Vector2f(600f, 635f);
            this.iMenuRectBlue = new Image(@"..\Content\Textures\Interface\RectBlue.png");
            this.iMenuRectRed = new Image(@"..\Content\Textures\Interface\RectRed.png");
            this.tMenuRectBlue = new Texture(this.iMenuRectBlue);
            this.tMenuRectRed = new Texture(this.iMenuRectRed);
            this.tMenuRectBlue.Smooth = true;
            this.tMenuRectRed.Smooth = true;
            int index = 0;
            int num2 = 0;
            while (true)
            {
                if (index >= this.sMenuRectHp.Length)
                {
                    int num3 = 0;
                    int num4 = 0;
                    while (true)
                    {
                        if (num3 >= this.sMenuRectDmg.Length)
                        {
                            int num5 = 0;
                            int num6 = 0;
                            while (num5 < this.sMenuRectSpd.Length)
                            {
                                this.sMenuRectSpd[num5] = new Sprite(this.tMenuRectBlue);
                                this.sMenuRectSpd[num5].Scale = new Vector2f(0.95f, 1f);
                                this.sMenuRectSpd[num5].Position = new Vector2f(794f, (float)(0x11d + num6));
                                num6 += 50;
                                num5++;
                            }
                            return;
                        }
                        this.sMenuRectDmg[num3] = new Sprite(this.tMenuRectBlue);
                        Sprite sprite1 = this.sMenuRectDmg[num3];
                        sprite1.Rotation = (float)(sprite1.Rotation + 90f);
                        this.sMenuRectDmg[num3].Scale = new Vector2f(0.95f, 1f);
                        this.sMenuRectDmg[num3].Position = new Vector2f((float)(0x25b + num4), 201f);
                        num4 += 60;
                        num3++;
                    }
                }
                this.sMenuRectHp[index] = new Sprite(this.tMenuRectRed);
                this.sMenuRectHp[index].Scale = new Vector2f(0.95f, 1f);
                this.sMenuRectHp[index].Position = new Vector2f(471f, (float)(0x11d + num2));
                num2 += 50;
                index++;
            }

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

        #region Menu
        public Sprite GetCircle1()
        {
            return this.sCircle1;
        }

        public Sprite GetCircle2()
        {
            return this.sCircle2;
        }

        public Sprite GetCircle3()
        {
            return this.sCircle3;
        }

        public Sprite GetCircle4()
        {
            return this.sCircle4;
        }
        public Sprite GetMenuButton()
        {
            return this.sMenuButton;
        }

        public Sprite GetMenuLevels()
        {
            return this.sMenuLevels;
        }

        public Sprite GetMenuRectBlue()
        {
            return this.sMenuRectHp[0];
        }

        public Sprite GetMenuShips()
        {
            return this.sMenuShips;
        }

        public Sprite GetMenuTable()
        {
            return this.sMenuTable;
        }

        public RectangleShape GetRectangleHp1()
        {
            return this.RectangleHp1;
        }

        public Text GetTextPlay()
        {
            return this.TextPlay;
        }
        #endregion

        #endregion


    }
}
