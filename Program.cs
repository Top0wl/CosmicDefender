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

           Clock clock = new Clock();       
            while (Window.IsOpen)
            {
                float time = clock.ElapsedTime.AsMicroseconds();
                clock.Restart();
                time = time / 800;
                //clock.Restart(); //перезагружает время

                Window.DispatchEvents();    //Cобираем ивенты
                Window.Clear();                                                     //Чистим экран
                Window.Draw(Content.GetTextureLevel1());                            //Прорисовываем уровень
                Ship.Update(time);                                                  //Прорисовываем корабль
                Window.Display();                                                   //Выводит всё на дисплей
                //
                //
                //
                //
                //
                //
                //
                //

                Window.Display();
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
