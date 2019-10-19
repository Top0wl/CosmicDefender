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
        private static int CountAsteroids = 0;
        static Game Logic = new Game();
        static Random rnd2 = new Random();
        static void Main(string[] args)
        {
            //Создание окна
            Window = new RenderWindow(new SFML.Window.VideoMode(WindowWidth, WindowHeight), "CosmicDefender");
            Window.SetVerticalSyncEnabled(true);
            Window.SetFramerateLimit(60);

            //Добавим событие на закрытие окна
            Window.Closed += Window_Closed;
            Window.Resized += Win_Resized;

            Game Logic = new Game();

            //Logic.CreateParticles(1000);

            //dynamic particles = ParticleSystem(1000);
            ParticleSystem particles = new ParticleSystem(5000);

            //Logic.CreateParticles(1000);
            Content.Load();                                                          //Загружаем в память текстуры




            //Player Ship = new Player("SpaceShip1.png", 500, 500, 106, 80);           //Загружаем корабль
            Ship Ship = new Ship("SpaceShip1.png", 500, 500, 106, 80);

            Clock clock = new Clock();
            Clock bullet_clock = new Clock();
            float bullet_cooldown;

            while (Window.IsOpen)
            {
                CreateAsteroid(100);
                bullet_cooldown = bullet_clock.ElapsedTime.AsSeconds();
                float time = clock.ElapsedTime.AsMicroseconds();
                clock.Restart();
                time = time / 800;
                Window.DispatchEvents();       //Cобираем ивенты

                Window.Clear();                                                 //Чистим экран  
                Window.Draw(Content.GetTextureLevel1(0.3F, 0.3F));                  //Прорисовываем уровень
                particles.Update();
                Window.Draw(particles);

                int shooting_ready = 0;

                if (Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    shooting_ready = 1;
                }

                if (shooting_ready == 1 && bullet_cooldown >= .2f)
                {
                    bullet_clock.Restart();
                    Bullet b = new Bullet();
                    Program.entities.Add(b);
                    shooting_ready = 0;
                    
                }

                int i = 0;
                foreach (Entity entity in entities)
                {
                    entity.Update(time);
                    entity.Draw();

                   if (entity.GetLife() == false)
                {
                    entities.RemoveAt(i);
                }
                   i++;
                }

                foreach (Entity a in entities)
                {
                    foreach (Entity b in entities)
                    {
                        if(a.GetName() == "Asteroid" && b.GetName() == "Bullet")
                            if(IsCollide(a,b))
                            {
                                a.SetLife(false);  b.SetLife(false);
                            }
                    }
                }

                //Ship.Update(time);                                                  //Прорисовываем корабль
                Ship.Update();
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

        private static void CreateAsteroid(int count)
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

       private static bool IsCollide(Entity a, Entity b)
        {
            return((b.GetX() - a.GetX())*(b.GetX() - a.GetX()) +
                (b.GetY() - a.GetY())*(b.GetY() - a.GetY()) <
                (b.GetSize() + a.GetSize())*(b.GetSize() + a.GetSize()));
            
        }
    }
}
