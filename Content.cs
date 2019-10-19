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
        private static Texture Texture0_Asteroid;
        private static Texture Texture0_Cursor;
        private static Sprite sBackground;
        private static Sprite sPlayer;
        private static Sprite cursorSprite;
        private static Sprite sAsteroid;
        public static Animation animAsteroid = new Animation("animAsteroid.png", 0, 0, 85, 100, 6, 5, 0.15f);

        // public static Player Ship1;

        //

        //Метод для загрузки текстуры
        public static void Load()
        {
            Texture0_Level1 = new Texture(CONTENT_DIRICTORY + "Level1.jpg");
            Texture0_Level1.Smooth = true;
            sBackground = new Sprite(Texture0_Level1);
            cursorSprite = new Sprite(Texture0_Cursor);
            Texture0_Asteroid = new Texture(CONTENT_DIRICTORY + "Asteroid1.png");
            Texture0_Asteroid.Smooth = true;
            sAsteroid = new Sprite(Texture0_Asteroid);

        }

        public static Sprite GetTextureLevel1(float a, float b)
        {
            sBackground.Scale = new Vector2f(a,b);
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
        public static Sprite GetTextureAsteroid()
        {
            return sAsteroid;
        }



    }
}
