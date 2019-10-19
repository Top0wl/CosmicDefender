using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace ComicDefender
{
    class Ship
    {
        private const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";
        private float x, y;
        private static Vector2f location = new Vector2f(0, 0);
        private Vector2f velocity = new Vector2f(0, 0);
        private Vector2f velocity2 = new Vector2f(0, 0);
        private Vector2f direction = new Vector2f(0, 0);
        private Vector2f Rotate = new Vector2f(0, 0);
        private static float rotat;
        private float VectorSpeed; //Cкорость корабля
        public Sprite sprite;
        private Texture texture;
        private Image image;

        public Ship(String F, float X, float Y, float W, float H)
        {
            string File = F;
            float w = W; float h = H;
            texture = new Texture(CONTENT_DIRICTORY + File);
            texture.Smooth = true;
            sprite = new Sprite(texture);
            sprite.Origin = new Vector2f(w / 2, h / 2);
            location = new Vector2f(X, Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            VectorSpeed = 2;
        }


        public void Update()
        {

            Vector2i pixelPos = Mouse.GetPosition(Program.Window);//забираем коорд курсора
            Vector2f pos = Program.Window.MapPixelToCoords(pixelPos);//переводим их в игровые (уходим от коорд окна
            Vector2f Rotate = pos - location;
            Rotate = Normalization(Rotate, pos.X, pos.Y);
            direction = Rotate;
            float v = 0.3f;
            rotat = (float)((Math.Atan2(Rotate.Y, Rotate.X) * 180 / Math.PI) - 90);
            sprite.Rotation = rotat;

            sprite.Position = location;

            location += velocity; // Где находится корабль
            



            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                float max = 2;
                /*
                if ((float)Math.Sqrt((velocity.X) * (velocity.X) + (velocity.Y) * (velocity.Y)) < 2)
                {
                    velocity += Rotate; //Мы двигаемся
                }
                else  // длинна больше 2
                {

                    velocity += Rotate;

                    if ((float)Math.Sqrt((velocity.X) * (velocity.X) + (velocity.Y) * (velocity.Y)) < 2)
                    {

                    }
                    else
                    {
                        velocity -= Rotate;
                    }
                }
                */
                    
                velocity += v * direction;

                float constanta = (float)Math.Sqrt( (VectorSpeed* VectorSpeed) / ( velocity.X * velocity.X + velocity.Y * velocity.Y));

                velocity2 = velocity * constanta;

                float Dvelocity = (float)Math.Sqrt((velocity.X) * (velocity.X) + (velocity.Y) * (velocity.Y));
                float Dvelocity2 = (float)Math.Sqrt((velocity2.X) * (velocity2.X) + (velocity2.Y) * (velocity2.Y));

                if (Dvelocity > Dvelocity2)
                {
                    velocity = velocity2;
                }

                    //Velocity : x =0.01 , y = 0.05

                    //Velocity2 x, y d = 2;
                    // 2 = sqrt (x^2 + y^2)
                    // 2 = sqrt (0.01^2 * const^2 + 0.05^2 * const^2)
                    // 4 = const^2(0.01^2 + 0.05^2)
                    // (4 / 0.01^2 + 0.05^2) = const^2
                    //const = sqrt (4 / 0.01^2 + 0.05^2)



                    
               // if ((float)Math.Sqrt((velocity.X) * (velocity.X) + (velocity.Y) * (velocity.Y)) > max)
                   // velocity = max;




            }

            if (location.X > 1280)
            {
                location.X = 0;
            }
            if (location.X < 0)
            {
                location.X = 1280;
            }

            if (location.Y > 720)
            {
                location.Y = 0;
            }
            if (location.Y < 0)
            {
                location.Y = 720;
            }

            x = location.X;
            y = location.Y;

            Program.Window.Draw(sprite);
        }

        public Vector2f Normalization(Vector2f vec, float X, float Y)
        {
            /*float x1 = location.X;
            float x2 = vec.X;
            float y1 = location.Y;
            float y2 = vec.Y;
            float d = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            float norm_x = vec.X / (10*d);
            float norm_y = vec.Y / (10*d);
            return new Vector2f(norm_x, norm_y);
            */
   
            float d = (float)Math.Sqrt((vec.X) * (vec.X) + (vec.Y) * (vec.Y));
            vec = vec / (10*d);
            return vec;
        }
        public static float GetX()
        {
            return location.X;
        }
        public static float GetY()
        {
            return location.Y;
        }
        public static float GetRotation()
        {
            return rotat;
        }
    }
}
