using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Player
    {
        private const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";     //Директроия для тексутры
        private float w, h, dx, dy, x, y;
        private float rotation;
        // public int dir, playerScore, health;
        private Texture texture;
        private Sprite sprite;
        private Image image;
        private String File;

        float deltaX = 0;
        float deltaY = 0;
        float speed = 0.3f;
        float deltaXmax = 0.09f;
        float deltaYmax = 0.09f;
        float deltaXmin = -0.09f;
        float deltaYmin = -0.09f;

        public Player(String F, float X, float Y, float W, float H)
        {
            File = F;
            w = W; h = H;
            texture = new Texture(CONTENT_DIRICTORY + File);
            texture.Smooth = true;
            sprite = new Sprite(texture);
            x = X; y = Y;
            sprite.Origin = new Vector2f(w / 2, h / 2);
            sprite.Position = new Vector2f(x, y);
            sprite.Scale = new Vector2f(0.4F, 0.4F);
        }


        public void Update(float time)
        {
            Vector2i pixelPos = Mouse.GetPosition(Program.Window);//забираем коорд курсора
            Vector2f pos = Program.Window.MapPixelToCoords(pixelPos);//переводим их в игровые (уходим от коорд окна
            float dX = pos.X - x;//вектор , колинеарный прямой, которая пересекает спрайт и курсор
            float dY = pos.Y - y;//он же, координата y
            rotation = (float)(((Math.Atan2((double)dY, (double)dX)) * 180 / 3.14159265) - 90);//получаем угол в радианах и переводим его в градусы
            sprite.Rotation = rotation;
            float distance = (float)Math.Sqrt(((pos.X - x) * (pos.X - x) + (pos.Y - y) * (pos.Y - y)));

            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                deltaX = (float)((speed * time * (pos.X - x)) / distance);
                deltaY = (float)((speed * time * (pos.Y - y)) / distance);
            }

            if (deltaX < speed)
                deltaX += speed * time;
            if (deltaX > -speed)
                deltaX -= speed * time;
            deltaX *= (float)(1 - Math.Min(time * 0.0001, 1));
            if (deltaX > deltaXmax)
                deltaX = deltaXmax;
            if (deltaX < deltaXmin)
                deltaX = deltaXmin;
            if (deltaY < speed)
                deltaY += speed * time;
            if (deltaY > -speed)
                deltaY -= speed * time;
            deltaY *= (float)(1 - Math.Min(time * 0.0001, 1));
            if (deltaY > deltaYmax)
                deltaY = deltaYmax;
            if (deltaY < deltaYmin)
                deltaY = deltaYmin;

            if (distance > 2)
            {
                x += deltaX * time;
                y += deltaY * time;
                sprite.Position = new Vector2f(x, y);
            }

            //
            /*       Если вылетает за предел окна       */
            //
            if (x > Program.WindowWidth) x = 0;
            if (x < 0) x = Program.WindowWidth;

            if (y > Program.WindowHeight) y = 0;
            if (y < 0) y = Program.WindowHeight;
            //

            Program.Window.Draw(sprite);
        }
    }
}
