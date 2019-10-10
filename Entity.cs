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

        public void Settings(Sprite obj, int x, int y, float rotation, int radius)
        {
            X = x;
            Y = y;
            Rotation = rotation;
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
        public void SetName(string name)
        {
            Name = name;
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
            return Dx;
        }
        public string GetName()
        {
            return Name;
        }

        public virtual void Update() { }

        public void Draw()
        {
            Asteroid.sprite.Position = new Vector2f(X, Y);
            Program.Window.Draw(Asteroid.sprite);
        }

    }
}
