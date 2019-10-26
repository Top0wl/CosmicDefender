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
        //Const
        public const int WindowWidth = 1280;
        public const int WindowHeight = 720;
        public static RenderWindow Window;
        public static List<Entity> entities = new List<Entity>();
        public static Content2 content;
        public static Ship Ship;


        static Game Logic = new Game();

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

            Menu menu = new Menu();
            Level1 level1 = new Level1();

            Game Logic = new Game();
            ParticleSystem particles = new ParticleSystem(5000);
            content = new Content2();
            content.Load();                                                          //Загружаем в память текстуры
            Content.Load();
            Ship = new Ship("SpaceShip1.png", 500, 500, 106, 80);                  //Загружаем корабль
            entities.Add(Ship);
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

                // Window.Draw(Content.GetTextureLevel1(0.3F, 0.3F));               //Прорисовываем уровень


                if (menu.IsOpen == true)
                {

                    Window.Draw(content.GetMenuTextBar1());
                    Window.Draw(content.GetMenu());                                 //Прорисовываем уровень
                }

                if (level1.IsOpen == true)
                { 

                    Window.Draw(Content.GetTextureLevel1(0.3F, 0.3F));
                #region Particles
                particles.Update();
                Window.Draw(particles);
                #endregion

                #region Logic
                Logic.Update(Ship, entities);
                Logic.CreateAsteroid(entities, 50);
                Logic.Enemy(entities, 10);
                #endregion
                }


                //Ship.Update(time);                                                  //Прорисовываем корабль

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

       /* private static void CreateAsteroid(int count)
        {
            int b = rnd2.Next(1, 100);
            if (b == 1)
            {
                if (CountAsteroids != count)
                {
                    //Logic.CreateParticles(100);
                    Asteroid a = new Asteroid();
                    entities.Add(a);
                    // if (a.GetLife() == false)
                    //  {
                    //      entities.RemoveAt(i);
                    //      a = null;
                    //  }
                    CountAsteroids++;

                }
            }
        }
        */

       /*private static bool IsCollide(Entity a, Entity b)
        {
            float bX = b.GetX();
            float aX = a.GetX();
            float bY = b.GetY();
            float aY = a.GetY();
            float bS = b.GetSize();
            float aS = a.GetSize();

            float q = ((bX - aX) * (bX - aX)) + ((bY - aY) * (bY - aY));
            float size = (bS + aS) * (bS + aS);
            if (q < size)
            {
                return true;
            }
            else return false;
                


            return ((b.GetX() - a.GetX())*(b.GetX() - a.GetX()) +
                (b.GetY() - a.GetY())*(b.GetY() - a.GetY()) <
                (b.GetSize() + a.GetSize())*(b.GetSize() + a.GetSize()));
            
        }     
        */
       

       /* private static bool IsCollide(Sprite first, Sprite second)
        {
            Vector2f firstRect = new Vector2f(first.TextureRect.Width, first.TextureRect.Width);
            firstRect.X *= first.Scale.X;
            firstRect.Y *= first.Scale.Y;

            Vector2f secondRect = new Vector2f(second.TextureRect.Width, second.TextureRect.Width);
            secondRect.X *= second.Scale.X;
            secondRect.Y *= second.Scale.Y;

            float r1 = (firstRect.X + firstRect.Y) / 4;
            float r2 = (secondRect.X + secondRect.Y) / 4;
            float xd = first.Position.X - second.Position.X;
            float yd = first.Position.Y - second.Position.Y;

            return (Math.Sqrt(xd* xd + yd* yd) <= r1 + r2);
        }
       */
}
}
