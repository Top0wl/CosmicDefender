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
    class Boss : Entity
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

        public Boss()
        {

        }

        public Boss(Sprite _sprite, Animation _animation, float _X, float _Y, int damage, float speed, float shoot_speed, int health, int countguns, string name)
        {
            sprite = new Sprite(_sprite);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            SetHealth(health);
            VectorSpeed = speed;
            Name = name; //  $$$$
            X = _X;
            Y = _Y;
            CountGuns = countguns;
            animEnemy = _animation;
            Settings(_animation, "Boss1", 0, 100, 100, 1f, 0.3f);
        }

        public Boss(Sprite _sprite, float _X, float _Y, int damage, float speed, float shoot_speed, int health, int countguns, string name)
        {
            sprite = new Sprite(_sprite);
            location = new Vector2f(_X, _Y);
            sprite.Position = location;
            sprite.Scale = new Vector2f(0.4F, 0.4F);
            SetHealth(health);
            VectorSpeed = speed;
            Name = name; //  $$$$
            X = _X;
            Y = _Y;
            CountGuns = countguns;
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
            rotat = (float)((Math.Atan2(Rotate.Y, Rotate.X) * 180 / Math.PI) + 90);
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

            if (animEnemy != null)
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
