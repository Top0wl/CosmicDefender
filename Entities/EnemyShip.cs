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
        private int BulletToShip;                                       //Длина от корабля до спавна пули
        protected float VectorSpeed;                                    //Максимальная Cкорость корабля
        protected float bullet_cooldown_max = 0.5f;                     //Скоростельность
        private float bullet_cooldown;

        //Пустой конструктор для последующей инициализации
        public EnemyShip()
        { 
        
        }

        public EnemyShip(Sprite _sprite, float _X, float _Y, float MaxSpeed, string name) // Параметр Name
        {
            sprite = new Sprite(_sprite);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            VectorSpeed = MaxSpeed;
            Name = name; //  $$$$
            X = _X;
            Y = _Y;
        }


        public override void Update(float time)
        {
            Vector2f pos = new Vector2f(Ship.GetX(), Ship.GetY());
            Vector2f Rotate = pos - location;
            RotateShoot = Rotate;
            Rotate = Normalization(Rotate, pos.X, pos.Y);
            direction = Rotate;
            float v = 0.3f;
            rotat = (float)((Math.Atan2(Rotate.Y, Rotate.X) * 180 / Math.PI)+90);
            sprite.Rotation = rotat;
            sprite.Position = location;
            location += velocity * time; // Где находится корабль

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


            //Stop
            if (Name == "ShootShip")                        //стрелок стреляет
            {
                if ((Math.Sqrt(RotateShoot.X * RotateShoot.X + RotateShoot.Y * RotateShoot.Y)) < 200) // ... и это корабль стрелок
                {
                    velocity = new Vector2f(0, 0);
                }
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
