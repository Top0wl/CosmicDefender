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
    class Ship : Entity
    {
        protected static Vector2f location = new Vector2f(0, 0);
        protected Vector2f velocity = new Vector2f(0, 0);
        protected Vector2f velocity2 = new Vector2f(0, 0);
        protected Vector2f direction = new Vector2f(0, 0);
        protected Vector2f Rotate = new Vector2f(0, 0);
        private static float rotat;
        private Clock bullet_clock = new Clock();
        //
        public int shooting_ready = 0;
        protected float VectorSpeed;                                  //Максимальная Cкорость корабля
        protected float bullet_cooldown_max = .2f;                     //Скоростельность
        private float bullet_cooldown;
        private int dmg;


        public Ship(Sprite _sprite , float _X, float _Y)
        {
            Name = "PlayerShip";
            sprite = new Sprite(_sprite);
            sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            VectorSpeed = 1.5f;
            dmg = 25;                                               //изменить попозже ????????????????????????????????????????
            X = _X;
            Y = _Y;
        }
        public void Settings(Sprite _sprite, float _X, float _Y)
        {
            Name = "PlayerShip";
            sprite = new Sprite(_sprite);
            sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            VectorSpeed = 1.5f;
            dmg = 25;                                               //изменить попозже ????????????????????????????????????????
            X = _X;
            Y = _Y;
        }



        public override void Update(float time)
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
            location += velocity * time; // Где находится корабль

            #region MoveShip
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                velocity += v * direction;
                float constanta = (float)Math.Sqrt( (VectorSpeed* VectorSpeed) / ( velocity.X * velocity.X + velocity.Y * velocity.Y));
                velocity2 = velocity * constanta;
                float Dvelocity = (float)Math.Sqrt((velocity.X) * (velocity.X) + (velocity.Y) * (velocity.Y));
                float Dvelocity2 = (float)Math.Sqrt((velocity2.X) * (velocity2.X) + (velocity2.Y) * (velocity2.Y));
                if (Dvelocity > Dvelocity2)
                {
                    velocity = velocity2;
                }
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

            X = location.X;
            Y = location.Y;

            #endregion

            #region Shoot

            bullet_cooldown = bullet_clock.ElapsedTime.AsSeconds();
            shooting_ready = 0;

            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                shooting_ready = 1;
            }
            if (shooting_ready == 1 && bullet_cooldown >= .2f)
            {
                bullet_clock.Restart();
                Bullet b = new Bullet(GetX() + sprite.Texture.Size.X * Rotate.X / 2, GetY() + sprite.Texture.Size.X * Rotate.Y / 2, GetRotation(), 0.2f, 20f);
                Program.entities.Add(b);
                shooting_ready = 0;
            }

            #endregion
          
            Program.Window.Draw(sprite);
        }

        private Vector2f Normalization(Vector2f vec, float X, float Y)
        {
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

        public int GetDamage()
        {
            return dmg;
        }
    }
}
