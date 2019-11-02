using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class ParticleSystem : Transformable, Drawable
    {
        protected const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";
        public VertexArray m_vertices;
        public List<Particle> m_particles;
        public int _count;
        public Random R = new Random();
        public ParticleSystem(uint count)
        {
            _count = (int)count;
            m_particles = new List<Particle>((int)count);
            m_vertices = new VertexArray(PrimitiveType.Points);
            for (int i = 0; i < count; i++)
            {
                float Angle = R.Next(1, 360);
                // float _speed = R.Next(0, 1000);
                float _speed = R.Next(1, 20) / 100.0f;
                float deltaX = (float)Math.Cos(Math.PI * (Angle - 90) / 180.0f) * _speed;
                float deltaY = (float)Math.Sin(Math.PI * (Angle - 90) / 180.0f) * _speed;
                float X = R.Next(1, 1280);
                float Y = R.Next(1, 720);
                float Q = ((R.Next(1, 4)) / 10.0f);
                int flag = R.Next(0, 1);
                m_particles.Add(new Particle(Angle, _speed, deltaX, deltaY, X, Y, Q, flag));
                m_vertices.Append(new Vertex(new Vector2f(X, Y), Color.White));
            }
        }
        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Texture = null;
            states.Transform *= Transform;
            target.Draw(m_vertices, states);
        }

        public void Update()
        {
            for (int i = 0; i != m_particles.Count(); i++)
            {
              
                var temp = m_vertices[(uint)i];

                m_particles[i].X += m_particles[i].DX;
                m_particles[i].Y += m_particles[i].DY;


                temp.Position = new Vector2f(m_particles[i].X, m_particles[i].Y);

                if (m_particles[i].q < 0.4 && m_particles[i].flag == 1)
                {
                    m_particles[i].q += 0.001f;
                    m_particles[i].flag = 1;
                }
                else
                {
                    m_particles[i].flag = 0;
                }
                if (m_particles[i].q > 0.1 && m_particles[i].flag == 0)
                {
                    m_particles[i].q -= 0.001f;
                }
                else
                {
                    m_particles[i].flag = 1;
                }

                temp.Color.A = (byte)(m_particles[i].q * 255);
                m_vertices[(uint)i] = temp;

            }
        }
    }

}