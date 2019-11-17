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
        private Font font;
        private Text TextPlay;
        private RectangleShape RectangleHp1;

        public Sprite BackGround;


        #region Animation

        private Animation aAnimAsteroid1;
        private Animation aBoss1;

        #endregion

        #region Sprites

        private Sprite sAnimAsteroid1;
        private Sprite sExplosion;
        private Sprite cursorSprite;
        private Sprite sAsteroid1;
        private Sprite sAsteroid2;
        private Sprite sShootShip;
        private Sprite sBomber;
        private Sprite sBullet;
        private Sprite sB_Health;
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
        private Sprite sTestButton;
        private Sprite sListUp;
        private Sprite sListDown;
        private Sprite sMiniBoss;
        private Sprite sBoss1;
        private Sprite sShield;

        private Sprite sLevel1;
        private Sprite sLevel2;
        private Sprite sLevel3;
        private Sprite sLevel4;
        private Sprite sLevel5;
        private Sprite sLevel6;

        private Sprite sBackgroundLevel1;
        private Sprite sBackgroundLevel2;
        private Sprite sBackgroundLevel3;
        private Sprite sBackgroundLevel4;
        private Sprite sBackgroundLevel5;
        private Sprite sBackgroundLevel6;


        #endregion

        #region Textures
        private Texture tAnimAsteroid1;

        private Texture tExplosion;
        private Texture tLevel1;
        private Texture tAsteroid2;
        private Texture tAsteroid1;
        private Texture tCursor;
        private Texture tShootShip;
        private Texture tBomber;
        private Texture tBullet;
        private Texture tB_Health;
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
        private Texture tListUp;
        private Texture tListDown;
        private Texture tMiniBoss;
        private Texture tBoss1;
        private Texture tShield;

        private Texture tLevel2;
        private Texture tLevel3;
        private Texture tLevel4;
        private Texture tLevel5;
        private Texture tLevel6;

        private Texture tBackgroundLevel1;
        private Texture tBackgroundLevel2;
        private Texture tBackgroundLevel3;
        private Texture tBackgroundLevel4;
        private Texture tBackgroundLevel5;
        private Texture tBackgroundLevel6;

        #endregion

        #region Images

        private Image iAnimAsteroid1;

        private Image iShootShip;
        private Image iExplosion;
        private Image iAsteroid2;
        private Image iAsteroid1;
        private Image iBullet;
        private Image iBomber;
        private Image iB_Health;
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
        private Image iMiniBoss;
        private Image iListUp;
        private Image iListUp2;
        private Texture tListUp2;
        public Sprite sListUp2;
        private Image iListDown;
        private Image iBoss1;
        private Image iShield;

        private Image iLevel1;
        private Image iLevel2;
        private Image iLevel3;
        private Image iLevel4;
        private Image iLevel5;
        private Image iLevel6;

        private Image iBackgroundLevel1;
        private Image iBackgroundLevel2;
        private Image iBackgroundLevel3;
        private Image iBackgroundLevel4;
        private Image iBackgroundLevel5;
        private Image iBackgroundLevel6;
        #endregion


        public void Load()
        {
            #region Font

            font = new Font(@"..\Content\Textures\Font\eng.ttf");

            #endregion

            #region Animation Asteroid1

            iAnimAsteroid1 = new Image(CONTENT_DIRICTORY + "Animation\\AnimAsteroid.png");
            tAnimAsteroid1 = new Texture(iAnimAsteroid1);
            tAnimAsteroid1.Smooth = true;
            sAnimAsteroid1 = new Sprite(tAnimAsteroid1);
            sAnimAsteroid1.Origin = new Vector2f(iAnimAsteroid1.Size.X / 2, iAnimAsteroid1.Size.Y / 2);

            #endregion

            #region Animation Boss1

            iBoss1 = new Image(CONTENT_DIRICTORY + "Bosses\\Boss1_Shield.png");
            tBoss1 = new Texture(iBoss1);
            tBoss1.Smooth = true;
            sBoss1 = new Sprite(tBoss1);
            sBoss1.Origin = new Vector2f(iBoss1.Size.X / 2, iBoss1.Size.Y / 2);

            #endregion

            #region Animation Explosive Asteroid

            iExplosion = new Image(CONTENT_DIRICTORY + "Explosive\\type_B.png");
            tExplosion = new Texture(iExplosion);
            tExplosion.Smooth = true;
            sExplosion = new Sprite(tExplosion);
            sExplosion.Origin = new Vector2f(iExplosion.Size.X / 2, iExplosion.Size.Y / 2);

            #endregion

            #region Enemy Ship
            iShootShip = new Image(CONTENT_DIRICTORY + "Enemy\\EnemyShip1_green.png");
            tShootShip = new Texture(iShootShip);
            tShootShip.Smooth = true;
            sShootShip = new Sprite(tShootShip);
            sShootShip.Origin = new Vector2f(iShootShip.Size.X / 2, iShootShip.Size.Y / 2);
            #endregion

            #region Bomber Ship
            iBomber = new Image(CONTENT_DIRICTORY + "Enemy\\playerShip3_red.png");
            tBomber = new Texture(iBomber);
            tBomber.Smooth = true;
            sBomber = new Sprite(tBomber);
            sBomber.Origin = new Vector2f(iBomber.Size.X / 2, iBomber.Size.Y / 2);
            #endregion

            #region Bonus_Health
            iB_Health = new Image(CONTENT_DIRICTORY + "Bonuses\\HP_Bonus.png");
            tB_Health = new Texture(iB_Health);
            tB_Health.Smooth = true;
            sB_Health = new Sprite(tB_Health);
            sB_Health.Origin = new Vector2f(iB_Health.Size.X / 2, iB_Health.Size.Y / 2);
            #endregion

            #region Mini Boss Ship
            iMiniBoss = new Image(CONTENT_DIRICTORY + "Enemy\\miniBoss.png");
            tMiniBoss = new Texture(iMiniBoss);
            tMiniBoss.Smooth = true;
            sMiniBoss = new Sprite(tMiniBoss);
            sMiniBoss.Origin = new Vector2f(iMiniBoss.Size.X / 2, iMiniBoss.Size.Y / 2);
            #endregion

            #region Asteroid1
            iAsteroid1 = new Image(CONTENT_DIRICTORY + "Animation\\animAsteroid.png");
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

            #region Shield

            iShield = new Image(CONTENT_DIRICTORY + "Upgrade\\Shield.png");
            tShield = new Texture(iShield);
            tShield.Smooth = true;
            sShield = new Sprite(tShield);

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
            MenuRectButtons ListButtonPlay = new MenuRectButtons(sMenuButton, "ButtonPlay", new Vector2f(560f, 600f));
            Program.menu.RectButtons.Add(ListButtonPlay);
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

            for (int index = 0, num2 = 0; index < sMenuRectHp.Length; index++)
            {
                this.sMenuRectHp[index] = new Sprite(this.tMenuRectRed);
                this.sMenuRectHp[index].Scale = new Vector2f(0.95f, 1f);
                this.sMenuRectHp[index].Position = new Vector2f(471f, (float)(0x11d + num2));
                num2 += 50;
            }
            for (int num5 = 0, num6 = 0; num5 < sMenuRectSpd.Length; num5++)
            {
                this.sMenuRectSpd[num5] = new Sprite(this.tMenuRectBlue);
                this.sMenuRectSpd[num5].Scale = new Vector2f(0.95f, 1f);
                this.sMenuRectSpd[num5].Position = new Vector2f(794f, (float)(0x11d + num6));
                num6 += 50;
            }
            for (int num3 = 0, num4 = 0; num3 < sMenuRectDmg.Length; num3++)
            {
                this.sMenuRectDmg[num3] = new Sprite(this.tMenuRectBlue);
                Sprite sprite1 = this.sMenuRectDmg[num3];
                sprite1.Rotation = (float)(sprite1.Rotation + 90f);
                this.sMenuRectDmg[num3].Scale = new Vector2f(0.95f, 1f);
                this.sMenuRectDmg[num3].Position = new Vector2f((float)(0x25b + num4), 201f);
                num4 += 60;
            }

            #endregion

            #region Test View ScrollBar


            #endregion

            #region ListUpButton

            iListUp = new Image(CONTENT_DIRICTORY + "Interface\\button_up1.png");
            tListUp = new Texture(iListUp);
            tListUp.Smooth = true;
            sListUp = new Sprite(tListUp);
            //sListUp.Position = new Vector2f(900, 100);

            MenuRectButtons ListUpButton = new MenuRectButtons(sListUp, "ButtonUp", new Vector2f(1100, 35));
            Program.menu.RectButtons.Add(ListUpButton);

            #endregion

            #region ListDownButton

            iListDown = new Image(CONTENT_DIRICTORY + "Interface\\button_down1.png");
            tListDown = new Texture(iListDown);
            tListDown.Smooth = true;
            sListDown = new Sprite(tListDown);
            //sListDown.Position = new Vector2f(900, 600);

            MenuRectButtons ListDownButton = new MenuRectButtons(sListDown, "ButtonDown", new Vector2f(1100, 685));
            Program.menu.RectButtons.Add(ListDownButton);

            #endregion

            #region TestButton
            //Нужен чтобы брать цвет

            sTestButton = new Sprite(sListUp);

            #endregion

            #region RectShipsForMenu

            #region Ship1_lock

            iShip1_lock = new Image(CONTENT_DIRICTORY + "Interface\\ship1_lock.png");
            tShip1_lock = new Texture(iShip1_lock);
            tShip1_lock.Smooth = true;
            sShip1_lock = new Sprite(tShip1_lock);
            //sShip1_lock.Origin = new Vector2f(iShip1_lock.Size.X / 2, iShip1_lock.Size.Y / 2);

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

            #region Ship9_unlock

            iShip9_unlock = new Image(CONTENT_DIRICTORY + "Interface\\ship9_unlock.png");
            tShip9_unlock = new Texture(iShip9_unlock);
            tShip9_unlock.Smooth = true;
            sShip9_unlock = new Sprite(tShip9_unlock);

            #endregion

            #endregion

            #region RectLevelsForMenu

            #region Level1

            iLevel1 = new Image(CONTENT_DIRICTORY + "Levels\\Level1_unlock.png");
            tLevel1 = new Texture(iLevel1);
            tLevel1.Smooth = true;
            sLevel1 = new Sprite(tLevel1);

            #endregion

            #region Level2

            iLevel2 = new Image(CONTENT_DIRICTORY + "Levels\\Level2_unlock.png");
            tLevel2 = new Texture(iLevel2);
            tLevel2.Smooth = true;
            sLevel2 = new Sprite(tLevel2);

            #endregion

            #region Level3

            iLevel3 = new Image(CONTENT_DIRICTORY + "Levels\\Level3_unlock.png");
            tLevel3 = new Texture(iLevel3);
            tLevel3.Smooth = true;
            sLevel3 = new Sprite(tLevel3);

            #endregion

            #region Level4

            iLevel4 = new Image(CONTENT_DIRICTORY + "Levels\\Level4_unlock.png");
            tLevel4 = new Texture(iLevel4);
            tLevel4.Smooth = true;
            sLevel4 = new Sprite(tLevel4);

            #endregion

            #region Level5

            iLevel5 = new Image(CONTENT_DIRICTORY + "Levels\\Level5_unlock.png");
            tLevel5 = new Texture(iLevel5);
            tLevel5.Smooth = true;
            sLevel5 = new Sprite(tLevel5);

            #endregion

            #region Level6

            iLevel6 = new Image(CONTENT_DIRICTORY + "Levels\\Level6_unlock.png");
            tLevel6 = new Texture(iLevel6);
            tLevel6.Smooth = true;
            sLevel6 = new Sprite(tLevel6);

            #endregion

            #endregion

            #region Levels

            #region Level1
            iBackgroundLevel1 = new Image(CONTENT_DIRICTORY + "Levels\\Level1.jpg");
            tBackgroundLevel1 = new Texture(iBackgroundLevel1);
            tBackgroundLevel1.Smooth = true;
            sBackgroundLevel1 = new Sprite(tBackgroundLevel1);
            sBackgroundLevel1.Scale = new Vector2f(0.4f, 0.4f);
            #endregion

            #region Level2
            iBackgroundLevel2 = new Image(CONTENT_DIRICTORY + "Levels\\Level2.jpg");
            tBackgroundLevel2 = new Texture(iBackgroundLevel2);
            tBackgroundLevel2.Smooth = true;
            sBackgroundLevel2 = new Sprite(tBackgroundLevel2);
            sBackgroundLevel2.Scale = new Vector2f(0.5f, 0.4f);
            #endregion

            #region Level3
            iBackgroundLevel3 = new Image(CONTENT_DIRICTORY + "Levels\\Level3.jpg");
            tBackgroundLevel3 = new Texture(iBackgroundLevel3);
            tBackgroundLevel3.Smooth = true;
            sBackgroundLevel3 = new Sprite(tBackgroundLevel3);
            sBackgroundLevel3.Scale = new Vector2f(0.4f, 0.4f);
            #endregion

            #region Level4
            iBackgroundLevel4 = new Image(CONTENT_DIRICTORY + "Levels\\Level4.jpg");
            tBackgroundLevel4 = new Texture(iBackgroundLevel4);
            tBackgroundLevel4.Smooth = true;
            sBackgroundLevel4 = new Sprite(tBackgroundLevel4);
            sBackgroundLevel4.Scale = new Vector2f(0.4f, 0.4f);
            #endregion

            #region Level5
            iBackgroundLevel5 = new Image(CONTENT_DIRICTORY + "Levels\\Level5.jpg");
            tBackgroundLevel5 = new Texture(iBackgroundLevel5);
            tBackgroundLevel5.Smooth = true;
            sBackgroundLevel5 = new Sprite(tBackgroundLevel5);
            sBackgroundLevel5.Scale = new Vector2f(0.4f, 0.4f);
            #endregion
            /*
            #region Level6
            iBackgroundLevel6 = new Image(CONTENT_DIRICTORY + "Levels\\Level6.jpg");
            tBackgroundLevel6 = new Texture(iBackgroundLevel6);
            tBackgroundLevel6.Smooth = true;
            sBackgroundLevel6 = new Sprite(tBackgroundLevel6);
            sBackgroundLevel6.Scale = new Vector2f(0.4f, 0.4f);
            #endregion
            */

            #endregion

        }
        #region Getters

        public void LoadListShips1()
        {
            Program.menu.RectShips.Clear();
            MenuRectShips Ship1Rect = new MenuRectShips(sShip1_lock, sShip1, "Ship1", new Vector2f(1000, 75), 25, 1.5f, .2f, 100, 1); //25 1.5f .2f 100
            Program.menu.RectShips.Add(Ship1Rect);

            MenuRectShips Ship2Rect = new MenuRectShips(sShip2_lock, sShip2, "Ship2", new Vector2f(1000, 175), 25, 1.5f, .2f, 100, 2); //15 1.7f .2f 100  2 пули за выстрел
            Program.menu.RectShips.Add(Ship2Rect);

            MenuRectShips Ship3Rect = new MenuRectShips(sShip3_lock, sShip3, "Ship3", new Vector2f(1000, 275), 25, 1.5f, .2f, 100, 1); //30 1.6f .25f 125
            Program.menu.RectShips.Add(Ship3Rect);

            MenuRectShips Ship4Rect = new MenuRectShips(sShip4_lock, sShip4, "Ship4", new Vector2f(1000, 375), 25, 1.5f, .2f, 100, 1); //45 1.8f .35f 75
            Program.menu.RectShips.Add(Ship4Rect);

            MenuRectShips Ship5Rect = new MenuRectShips(sShip5_lock, sShip5, "Ship5", new Vector2f(1000, 475), 25, 1.5f, .2f, 100, 1); //25 1.3f .15f 150
            Program.menu.RectShips.Add(Ship5Rect);

            MenuRectShips Ship6Rect = new MenuRectShips(sShip6_lock, sShip6, "Ship6", new Vector2f(1000, 575), 25, 1.5f, .2f, 100, 1); //2 1.3f 1f? 100  лазерный
            Program.menu.RectShips.Add(Ship6Rect);

        }

        public void LoadListShips2()
        {
            Program.menu.RectShips.Clear();
             
            MenuRectShips Ship7Rect = new MenuRectShips(sShip7_lock, sShip7, "Ship7", new Vector2f(1000, 75), 25, 1.8f, .2f, 150, 2); //25 1.8f .2f 150
            Program.menu.RectShips.Add(Ship7Rect);

            MenuRectShips Ship8Rect = new MenuRectShips(sShip8_lock, sShip8, "Ship8", new Vector2f(1000, 175), 25, 1.2f, .25f, 200, 2); //50 1.3f .25f 200
            Program.menu.RectShips.Add(Ship8Rect);

            MenuRectShips Ship9Rect = new MenuRectShips(sShip9_lock, sShip9, "Ship9", new Vector2f(1000, 275), 50, 2f, .1f, 300, 2); //50 2f .1f 300
            Program.menu.RectShips.Add(Ship9Rect);

        }

        public void LoadListLevels1()
        {
            Program.menu.RectLevels.Clear();

            MenuRectLevels Level1Rect = new MenuRectLevels(sLevel1, "Level1", new Vector2f(20, 75), sBackgroundLevel1);
            Program.menu.RectLevels.Add(Level1Rect);

            MenuRectLevels Level2Rect = new MenuRectLevels(sLevel2, "Level1", new Vector2f(20, 175), sBackgroundLevel2);            //Поменять sLvl
            Program.menu.RectLevels.Add(Level2Rect);

            MenuRectLevels Level3Rect = new MenuRectLevels(sLevel3, "Level1", new Vector2f(20, 275));
            Program.menu.RectLevels.Add(Level3Rect);

            MenuRectLevels Level4Rect = new MenuRectLevels(sLevel4, "Level1", new Vector2f(20, 375));
            Program.menu.RectLevels.Add(Level4Rect);

            MenuRectLevels Level5Rect = new MenuRectLevels(sLevel5, "Level1", new Vector2f(20, 475));
            Program.menu.RectLevels.Add(Level5Rect);

            MenuRectLevels Level6Rect = new MenuRectLevels(sLevel6, "Level1", new Vector2f(20, 575));
            Program.menu.RectLevels.Add(Level6Rect);
        }


        public Sprite GetsAnimAsteroid1()
        {
            return sAnimAsteroid1;
        }

        public Sprite GetBoss1()
        {
            return sBoss1;
        }

        public Sprite GetMiniBoss()
        {
            return sMiniBoss;
        }

        public Sprite GetsExplosion()
        {
            return sExplosion;
        }

        public Sprite GetsShootShip()
        {
            return sShootShip;
        }

        public Sprite GetShield()
        {
            return sShield;
        }

        public Sprite GetsBomber()
        {
            return sBomber;
        }

        public Sprite GetsB_Health()
        {
            return sB_Health;
        }

        public Sprite GetLevel1()
        {
            return sLevel1;
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

        public Sprite GetLevel2()
        {
            return this.sLevel2;
        }
        public Sprite GetLevel3()
        {
            return this.sLevel3;
        }
        public Sprite GetLevel4()
        {
            return this.sLevel4;
        }
        public Sprite GetLevel5()
        {
            return this.sLevel5;
        }

        public Sprite GetLevel6()
        {
            return this.sLevel6;
        }


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
        public Sprite GetListUpButton()
        {
            return sListUp;
        }
        public Sprite GetListDownButton()
        {
            return sListDown;
        }

        public Sprite GetColorButtonUp()
        {
            return sTestButton;
        }

        #endregion

        #region Levels

        public Sprite GetBackgroundLevel1()
        {
            return sBackgroundLevel1;
        }

        public Sprite GetBackgroundLevel2()
        {
            return sBackgroundLevel2;
        }

        public Sprite GetBackgroundLevel3()
        {
            return sBackgroundLevel3;
        }

        public Sprite GetBackgroundLevel4()
        {
            return sBackgroundLevel4;
        }

        public Sprite GetBackgroundLevel5()
        {
            return sBackgroundLevel5;
        }

        public Sprite GetBackgroundLevel6()
        {
            return sBackgroundLevel6;
        }

        #endregion

        #endregion

    }
}