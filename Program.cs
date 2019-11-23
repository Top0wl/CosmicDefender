using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComicDefender
{
    class Program
    {

        #region Vars and Consts
        public const int WindowWidth = 1280;
        public const int WindowHeight = 720;
        public static RenderWindow Window;
        public static List<Entity> entities = new List<Entity>();
        public static Content2 content;
        public static Ship Ship;
        public static Menu menu;
        public static List<Level> levels = new List<Level>();
       // public static Level level;
        static Game Logic = new Game();
        public static Constants Constants;
        #endregion

        static void Main(string[] args)
        {
            #region Create Window
            //Создание окна
            Window = new RenderWindow(new SFML.Window.VideoMode(WindowWidth, WindowHeight), "CosmicDefender");
            Window.SetVerticalSyncEnabled(true);
            Window.SetFramerateLimit(60);
            #endregion

            #region События

            //Добавим событие на закрытие окна
            Window.Closed += Window_Closed;
            Window.Resized += Win_Resized;

            #endregion

            #region Initialization Start Components

            #region Content and Menu Load

            content = new Content2();
            menu = new Menu();
            content.Load();
            Constants = new Constants();
            menu.Load();

            #endregion

            #region Levels

            Level level1 = new Level(content.GetBackgroundLevel1(), Constants.Boss1, "Level1");
            levels.Add(level1);
            Level level2 = new Level(content.GetBackgroundLevel2(), Constants.Boss2, "Level2");
            levels.Add(level2);
            Level level3 = new Level(content.GetBackgroundLevel3(), Constants.Boss3, "Level3");
            levels.Add(level3);



            //level1 = new level(Content2.GetSpriteBoss, harakterist);
            //level1 = new level(Const.Boss1Hp, , harakterist);


            #endregion

            #region Game Logic and Particles
            Game Logic = new Game();                                            //Логика

            ParticleSystem particles = new ParticleSystem(5000);                //ParticleSystem

            Content.Load();                                                     //Content

            #endregion


            Ship = new Ship(content.GetShip1(), 500, 500, 25, 1.5f, .2f, 100, 1);                      //Загружаем корабль(пока что только один корабль с дамагом 25)
            //Ship = new Ship();
            entities.Add(Ship);                                                                        //Добавляем его в лист объектов


            Clock clock = new Clock();

            #endregion

            while (Window.IsOpen)
            {
                #region Time

                float time = clock.ElapsedTime.AsMicroseconds();
                clock.Restart();
                time = time / 10000;

                #endregion

                Window.DispatchEvents();                                            //Cобираем ивенты
                Window.Clear();                                                     //Чистим экран  

                #region If Open Menu

                if (menu.IsOpen == true)
                {
                    menu.Update();
                }

                #endregion


                foreach (Level level in levels.ToList())
                {
                    if (level.IsOpen == true)
                    {
                        Window.Draw(level.Background);

                        #region Particles
                        particles.Update();
                        Window.Draw(particles);
                        #endregion

                        #region Logic
                        Logic.Update(Ship, entities);
                        Logic.CreateAsteroid(entities, 1000);
                        Logic.Enemy(entities, 0, level.LevelBoss);
                        #endregion
                    }

                }


                Window.Display();                                                   //Выводит всё на дисплей
            }

        }


        private static void Win_Resized(object sender, SizeEventArgs e)
        {
            //Window.SetView(new View(new FloatRect(0, 0, e.Width, e.Height)));
        }

        private static void Window_Closed(object sender, EventArgs e)
        {
            Window.Close();
        }

  
    }
}
