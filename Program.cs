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
        static void Main(string[] args)
        {
           //Создание окна
           Window = new RenderWindow(new SFML.Window.VideoMode(WindowWidth, WindowHeight), "CosmicDefender");
            
           //Добавим событие на закрытие окна
           Window.Closed += Window_Closed;
           Window.Resized += Win_Resized;

           Content.Load();                                                          //Загружаем в память текстуры
           Player Ship = new Player("SpaceShip1.png", 500, 500, 106, 80);           //Загружаем корабль
          // Random rdn = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 100; i++)
            { 
              //  int a1 = rdn.Next(1, WindowWidth);
              //  int a2 = rdn.Next(1, WindowHeight);
              //  int a3 = rdn.Next(1, 360);
              //  float speed = (rdn.Next(100, 500) / 10000);

                Asteroid a = new Asteroid();

               // a.Settings("Asteroid1.png","Asteroid", a1, a2, a3, 0.4F, speed);
                entities.Add(a);

                if (a.GetLife() == false)
                {
                    entities.RemoveAt(i);
                    a = null;
                }
            }

            Clock clock = new Clock();
            Clock bullet_clock = new Clock();
            float bullet_cooldown;

            while (Window.IsOpen)
            {
                bullet_cooldown = bullet_clock.ElapsedTime.AsSeconds();
                float time = clock.ElapsedTime.AsMicroseconds();
                clock.Restart();
                time = time / 800;
                Window.DispatchEvents();                                            //Cобираем ивенты
                Window.Clear();                                                      //Чистим экран
                Window.Draw(Content.GetTextureLevel1(0.3F, 0.3F));                  //Прорисовываем уровень

                int shooting_ready = 0;

                if (Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    shooting_ready = 1;
                }

                if (shooting_ready == 1 && bullet_cooldown >= .2f)
                {
                    bullet_clock.Restart();
                    Bullet b = new Bullet(/*"Bullet.png",32,128*/);
                        //b.Settings(Bullet.sprite, Player.GetX(), Player.GetY(), Player.GetRotation(), 10);
                        Program.entities.Add(b);
                        shooting_ready = 0;
                }

                foreach (Entity entity in entities)
                {
                    if (entities.Count() > 100)
                    {
                        entities.Count();
                    }
                    entity.Update();
                    entity.Draw();
                }

                Ship.Update(time);                                                  //Прорисовываем корабль
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
