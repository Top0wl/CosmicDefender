using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Content : Transformable
    {
        //Директория к текстурам
        private const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";

        //Название переменных для всех текстур

        private static Texture Texture0_Level1;
        private static Texture Texture0_Cursor;
        private static Sprite sBackground;
        private static Sprite sPlayer;
        private static Sprite cursorSprite;

       // public static Player Ship1;

        //

        //Метод для загрузки текстуры
        public static void Load()
        {
            Texture0_Level1 = new Texture(CONTENT_DIRICTORY + "Level1.jpg");
            Texture0_Level1.Smooth = true;

            //Ship1 = new Player("SpaceShip1.png", 500, 500, 106, 80);


            sBackground = new Sprite(Texture0_Level1);


            cursorSprite = new Sprite(Texture0_Cursor);
  
        }

        public static Sprite GetTextureLevel1()
        {
            return sBackground;
        }
        public static Sprite GetTextureShip1()
        {
            return sPlayer;
        }
        public static Sprite GetTextureCursor()
        {
            return cursorSprite;
        }



    }
}
