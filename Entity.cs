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
        private float X,Y,Dx,Dy,Rotation;
        private bool life;
        private string Name;


        public Entity()
        {
            life = true;
        }

        public void Settings(Sprite obj, float x, float y, float rotation, int radius)
        {
            X = x;
            Y = y;
           // Rotation = rotation;
        }
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
        public bool GetLife()
        {
            return life;
        }
        public void SetLife(bool _Life)
        {
            life = _Life;
        }

        public virtual void Update() { }

        public virtual void Draw() { }

    }
}
