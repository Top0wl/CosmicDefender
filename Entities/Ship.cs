﻿using System;
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
        public int CountGuns = 0;
        public float VectorSpeed;                                  //Максимальная Cкорость корабля
        public float bullet_cooldown_max;                     //Скоростельность (была .2f)
        public float bullet_cooldown;
        public int dmg;
        public float Shoot_Speed = 20f;

        public Ship()
        { 
        }

        public Ship(Sprite _sprite , float _X, float _Y, int damage, float speed, float shoot_speed, int health, int countguns)
        {
            Name = "PlayerShip";
            sprite = new Sprite(_sprite);
            sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            bullet_cooldown_max = shoot_speed;
            VectorSpeed = speed;
            dmg = damage;                                               //изменить попозже ????????????????????????????????????????
            Health = health;
            CountGuns = countguns;
            X = _X;
            Y = _Y;
        }
        public void Settings(Sprite _sprite, float _X, float _Y, int damage, float speed, float shoot_speed, int health, int countguns)
        {
            Name = "PlayerShip";
            sprite = new Sprite(_sprite);
            sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            bullet_cooldown_max = shoot_speed;
            VectorSpeed = speed;
            dmg = damage;                                                   //изменить попозже ????????????????????????????????????????
            Health = health;
            CountGuns = countguns;
            X = _X;
            Y = _Y;
        }



        public override void Update(float time)
        {
            Vector2i pixelPos = Mouse.GetPosition(Program.Window);//забираем коорд курсора
            Vector2f pos = Program.Window.MapPixelToCoords(pixelPos);//переводим их в игровые (уходим от коорд окна
            Vector2f Rotate = pos - location;
            Vector2f RotateToGun;
            RotateToGun.Y = 1;
            RotateToGun.X = (((-1) * (Rotate.Y * RotateToGun.Y)) / (Rotate.X));
            RotateToGun = Normalization(RotateToGun, pos.X, pos.Y);

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

                if (CountGuns == 1)
                {
                    Bullet b1 = new Bullet(GetX() + sprite.Texture.Size.X * Rotate.X, GetY() + sprite.Texture.Size.X * Rotate.Y, GetRotation(), 0.2f, Shoot_Speed);
                    Program.entities.Add(b1);
                }

                if (CountGuns == 2)
                {
                    Bullet b1 = new Bullet(GetX() + 100 * RotateToGun.X + sprite.Texture.Size.X * Rotate.X, GetY() + 100 * RotateToGun.Y + sprite.Texture.Size.X * Rotate.Y, GetRotation(), 0.2f, Shoot_Speed);
                    Program.entities.Add(b1);

                    Bullet b2 = new Bullet(GetX() + (-100) * RotateToGun.X + sprite.Texture.Size.X * Rotate.X, GetY() + (-100) * RotateToGun.Y + sprite.Texture.Size.X * Rotate.Y, GetRotation(), 0.2f, Shoot_Speed);
                    Program.entities.Add(b2);
                }
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
