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
        static void Main(string[] args)
        {
           //Создание окна
           Window = new RenderWindow(new SFML.Window.VideoMode(WindowWidth, WindowHeight), "CosmicDefender");
            
           //Добавим событие на закрытие окна
           Window.Closed += Window_Closed;
           Window.Resized += Win_Resized;

           Content.Load();                                                          //Загружаем в память текстуры
           Player Ship = new Player("SpaceShip1.png", 500, 500, 106, 80);           //Загружаем корабль
            List<Entity> entities = new List<Entity>();
            //List<Entity> entities;
            Random rdn = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 15; i++)
            { 
                    int a1 = rdn.Next(1, WindowWidth);
                    int a2 = rdn.Next(1, WindowHeight);
                    int a3 = rdn.Next(1, 360);
                    float speed = rdn.Next(100, 1000);

                Asteroid a = new Asteroid("Asteroid1.png", 43, 43, speed);


                a.Settings(Asteroid.sprite, a1, a2, a3, 10);
                entities.Add(a);
            }


           Clock clock = new Clock();       
            while (Window.IsOpen)
            {
                float time = clock.ElapsedTime.AsMicroseconds();
                clock.Restart();
                time = time / 800;
                //clock.Restart(); //перезагружает время
                Window.DispatchEvents();    //Cобираем ивенты


                Window.Clear();                                                     //Чистим экран
                Window.Draw(Content.GetTextureLevel1(0.3F, 0.3F));  //Прорисовываем уровень

                foreach (Entity entity in entities)
                {
                    
                    entity.Update();
                    entity.Draw();
                  //  Window.Display();
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
