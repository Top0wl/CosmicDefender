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
        public static Level1 level1;
        static Game Logic = new Game();
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
            menu.Load();

            #endregion

            #region Levels

            level1 = new Level1();

            #endregion

            #region Game Logic and Particles
            Game Logic = new Game();                                            //Логика

            ParticleSystem particles = new ParticleSystem(5000);                //ParticleSystem

            Content.Load();                                                     //Content

            #endregion

            Ship = new Ship(content.GetShip1(), 500, 500, 25, 1.5f, .2f, 100, 1);                      //Загружаем корабль(пока что только один корабль с дамагом 25)
            entities.Add(Ship);                                                 //Добавляем его в лист объектов

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

                #region If Open LVL 1

                if (level1.IsOpen == true)
                { 
                Window.Draw(Content.GetTextureLevel1(0.3F, 0.3F));

                #region Particles
                particles.Update();
                Window.Draw(particles);
                #endregion

                #region Logic
                Logic.Update(Ship, entities);
                Logic.CreateAsteroid(entities, 0);
                Logic.Enemy(entities, 10);
                #endregion
                }

                #endregion

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
