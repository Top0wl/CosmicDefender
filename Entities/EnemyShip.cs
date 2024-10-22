﻿using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class EnemyShip : Entity
    {

        protected Vector2f location = new Vector2f(0, 0);
        protected Vector2f velocity = new Vector2f(0, 0);
        protected Vector2f velocity2 = new Vector2f(0, 0);
        protected Vector2f direction = new Vector2f(0, 0);
        protected Vector2f Rotate = new Vector2f(0, 0);
        private static float rotat;
        private Vector2f RotateShoot = new Vector2f(0, 0);
        private Clock bullet_clock = new Clock();
        //
        public int shooting_ready = 0;
        public int CountGuns;
        private int BulletToShip;                                       //Длина от корабля до спавна пули
        protected float VectorSpeed;                                    //Максимальная Cкорость корабля
        protected float bullet_cooldown_max = 0.5f;                     //Скоростельность
        protected float bullet_cooldown_max_miniBoss = 2f;
        private float bullet_cooldown;
        public Animation animEnemy;
        public bool IsAnimation;
        //Пустой конструктор для последующей инициализации
        public EnemyShip()
        { 
        
        }


        public EnemyShip(Sprite _sprite, float _X, float _Y, float MaxSpeed, string name, int countguns, bool _animation, float size) // Параметр Name
        {
            if (_animation == true)
            {
                animEnemy = new Animation(_sprite, 0, 0, 338, 338, 3, 0.02f);   //ПАРАМЕТРЫ ДЛЯ КАЖДОГО БОССА ?????????????????????????????????????????????
            }

            IsAnimation = _animation;
            sprite = new Sprite(_sprite);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(size, size);
            VectorSpeed = MaxSpeed;
            Name = name; //  $$$$
            X = _X;
            Y = _Y;
            CountGuns = countguns;

            if (_animation == true)
            {
                Settings(animEnemy, "Boss1", 0, 100, 100, 0.5f, 0.3f);
            }
        }




        public override void Update(float time)
        {
            Vector2f pos = new Vector2f(Ship.GetX(), Ship.GetY());
            Vector2f Rotate = pos - location;
            RotateShoot = Rotate;

            Vector2f RotateToGun;
            RotateToGun.Y = 1;
            RotateToGun.X = (((-1) * (Rotate.Y * RotateToGun.Y)) / (Rotate.X));
            RotateToGun = Normalization(RotateToGun, pos.X, pos.Y);

            Rotate = Normalization(Rotate, pos.X, pos.Y);
            direction = Rotate;

            float v = 0.3f;
            rotat = (float)((Math.Atan2(Rotate.Y, Rotate.X) * 180 / Math.PI)+90);
            sprite.Rotation = rotat;
            sprite.Position = location;
            location += velocity * time; // Где находится корабль
            Random rnd = new Random();

            velocity += v * direction;
            float constanta = (float)Math.Sqrt((VectorSpeed * VectorSpeed) / (velocity.X * velocity.X + velocity.Y * velocity.Y));
            velocity2 = velocity * constanta;
            float Dvelocity = (float)Math.Sqrt((velocity.X) * (velocity.X) + (velocity.Y) * (velocity.Y));
            float Dvelocity2 = (float)Math.Sqrt((velocity2.X) * (velocity2.X) + (velocity2.Y) * (velocity2.Y));
            if (Dvelocity > Dvelocity2)
            {
                velocity = velocity2;
            }
            X = location.X;
            Y = location.Y;

            if (Name == "ShootShip")                        //стрелок стреляет
            {
                if ((Math.Sqrt(RotateShoot.X * RotateShoot.X + RotateShoot.Y * RotateShoot.Y)) < 500) // ... и это корабль стрелок
                {
                    bullet_cooldown = bullet_clock.ElapsedTime.AsSeconds();
                    shooting_ready = 1;
                    if (shooting_ready == 1 && bullet_cooldown >= bullet_cooldown_max)
                    {
                        bullet_clock.Restart();
                        Bullet b = new Bullet((location.X + 300  * Rotate.X), (location.Y + 300 * Rotate.Y), rotat + 180, 0.2f, 2f);
                        Program.entities.Add(b);
                        shooting_ready = 0;
                    }
                }
                else shooting_ready = 0;
            }
            
            if(Name == "Bomber")                        //бомбер не стреляет
            shooting_ready = 0;

            if (Name == "MiniBoss")
            {
                if ((Math.Sqrt(RotateShoot.X * RotateShoot.X + RotateShoot.Y * RotateShoot.Y)) < 500)
                {
                    bullet_cooldown = bullet_clock.ElapsedTime.AsSeconds();
                    shooting_ready = 1;
                    if (shooting_ready == 1 && bullet_cooldown >= bullet_cooldown_max_miniBoss)
                    {
                        bullet_clock.Restart();

                        if (CountGuns == 1)
                        {
                            Bullet b1 = new Bullet(location.X + sprite.Texture.Size.X * Rotate.X, location.Y + sprite.Texture.Size.X * Rotate.Y, rotat + 180, 0.3f, 1.5f);
                            Program.entities.Add(b1);
                        }

                        if (CountGuns == 4)
                        {
                            int a = rnd.Next(1,3);

                            if (a == 1)
                            {
                                Bullet b1 = new Bullet(location.X + 150 * RotateToGun.X + sprite.Texture.Size.X * 3 * Rotate.X, location.Y + 150 * RotateToGun.Y + sprite.Texture.Size.X * 3 * Rotate.Y, rotat + 180, 0.3f, 1.5f);
                                Program.entities.Add(b1);

                                Bullet b2 = new Bullet(location.X + (-150) * RotateToGun.X + sprite.Texture.Size.X * 3 * Rotate.X, location.Y + (-150) * RotateToGun.Y + sprite.Texture.Size.X * 2 * Rotate.Y, rotat + 180, 0.3f, 1.5f);
                                Program.entities.Add(b2);
                            }
                            if (a == 2)
                            {
                                Bullet b3 = new Bullet(location.X + 300 * RotateToGun.X + sprite.Texture.Size.X * 1.5f * Rotate.X, location.Y + 300 * RotateToGun.Y + sprite.Texture.Size.X * 1.5f * Rotate.Y, rotat + 180, 0.3f, 1.5f);
                                Program.entities.Add(b3);
                                Bullet b4 = new Bullet(location.X + (-300) * RotateToGun.X + sprite.Texture.Size.X * 1.5f * Rotate.X, location.Y + (-300) * RotateToGun.Y + sprite.Texture.Size.X * 1.5f * Rotate.Y, rotat + 180, 0.3f, 1.5f);
                                Program.entities.Add(b4);
                            }
                        }
                        shooting_ready = 0;
                    }
                }
                else shooting_ready = 0;
            }


            //Stop
            if (Name == "ShootShip")                        //стрелок стреляет
            {
                if ((Math.Sqrt(RotateShoot.X * RotateShoot.X + RotateShoot.Y * RotateShoot.Y)) < 200) // ... и это корабль стрелок
                {
                    velocity = new Vector2f(0, 0);
                }
            }

            if (Name == "MiniBoss")                        //стрелок стреляет
            {
                if ((Math.Sqrt(RotateShoot.X * RotateShoot.X + RotateShoot.Y * RotateShoot.Y)) < 300) // ... и это корабль стрелок
                {
                    velocity = new Vector2f(0, 0);
                }
            }

            if (IsAnimation == true)
            {
                sprite = animEnemy.sprite;
                animEnemy.update();
            }

            Program.Window.Draw(sprite);

        }

        private Vector2f Normalization(Vector2f vec, float X, float Y)
        {
            float d = (float)Math.Sqrt((vec.X) * (vec.X) + (vec.Y) * (vec.Y));
            vec = vec / (10 * d);
            return vec;
        }
    }
}
