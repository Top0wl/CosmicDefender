using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Entity
    {
        //Константы
        protected const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";
        //
        protected float X, Y;                 //Координаты объекта
        private float Dx, Dy;               //Скорость объекта
        private float Rotation;             //Направление объекта
        private float Size;                 //Размер объекта
        protected int Health;                  //Здоровье
        protected string Name;                //Имя объекта
        private float Speed;                //Скорость объекта
        public Sprite sprite;
        protected Texture texture;
        protected Image image;
        public Animation animation;

        public Entity()
        {
            Health = 100;
        }

        public Entity(int _health)
        {
            Health = _health;
        }



        //Настройки объекта
        public void Settings(Sprite _sprite, string _name, float x, float y, float rotation, float size, float _speed)
        {
            sprite = new Sprite(_sprite);
            sprite.Scale = new Vector2f(size, size);
            sprite.Origin = new Vector2f(sprite.Texture.Size.X/2, sprite.Texture.Size.Y / 2);
            Name = _name;
            X = x;
            Y = y;
            Rotation = rotation;
            Size = size;
            Speed = _speed;
            float deltaX = (float)Math.Cos(Math.PI * (rotation - 90) / 180.0f) * -1 * _speed;
            float deltaY = (float)Math.Sin(Math.PI * (rotation - 90) / 180.0f) * -1 * _speed;
            Dx = deltaX;
            Dy = deltaY;
            X += Dx/3;
            Y += Dy/3;
        }

        public void Settings(Animation a, string _name, float x, float y, float rotation, float size, float _speed)
        {
            a.sprite.Scale = new Vector2f(size, size);
            Name = _name;
            animation = a;
            X = x;
            Y = y;
            animation.X = x;
            animation.Y = y;
            animation.sprite.Rotation = rotation;
            Size = size;
            Speed = _speed;
            float deltaX = (float)Math.Cos(Math.PI * (rotation - 90) / 180.0f) * -1 * _speed;
            float deltaY = (float)Math.Sin(Math.PI * (rotation - 90) / 180.0f) * -1 * _speed;
            Dx = deltaX;
            Dy = deltaY;
          //  X += 3 * Dx;
           // Y += 3 * Dy;
            animation = a;

        }

        //Урон предмету
        public void damage(int _damage)
        {
            Health -= _damage;
        }


        //Виртуальные функции
        public virtual void Update(float time) { }
        public virtual void Draw() { }

        //Геттеры и Сеттеры
        public void SetX(float x)
        {
            X = x;
        }
        public void SetY(float y)
        {
            Y = y;
        }
        public void SetDx(float dx)
        {
            Dx = dx;
        }
        public void SetDy(float dy)
        {
            Dy = dy;
        }
        public float GetX()
        {
            return X;
        }
        public float GetY()
        {
            return Y;
        }
        public float GetDx()
        {
            return Dx;
        }
        public float GetDy()
        {
            return Dy;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public float GetRotation()
        {
            return Rotation;
        }
        public void SetRotation(float _Rotation)
        {
            Rotation = _Rotation;
        }
        public int GetHealth()
        {
            return Health;
        }
        public void SetHealth(int _health)
        {
            Health = _health;
        }
        public float GetSize()
        {
            return Size;
        }
        public void SetSize(float _size)
        {
            Size = _size;
        }
    }
}
