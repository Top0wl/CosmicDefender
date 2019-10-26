using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class ParticleEngineSystem : Transformable, Drawable
    {

        public VertexArray m_vertices;
        public Time m_lifetime;
        public List<ParticleEngine> m_particles;
        public Vector2f m_emitter;
        public ParticleEngineSystem(uint count)
        {

            m_particles = new List<ParticleEngine>((int)count);
            m_emitter = new Vector2f(0, 0);
            m_vertices = new VertexArray(PrimitiveType.Points);
            for (int i = 0; i != count; i++)
            {
                m_vertices.Append(new Vertex(m_emitter, Color.White));
            }
            m_lifetime = Time.FromSeconds(0.2f);
            for (int i = 0; i < count; i++)
            {
                m_particles.Add(new ParticleEngine());
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Texture = null;
            states.Transform *= Transform;
            target.Draw(m_vertices, states);
        }

        public void Update(Time Elapsed, Random R)
        {
            for (int i = 0; i != m_particles.Count(); i++)
            {
                var temp = m_vertices[(uint)i];
                m_particles[i].lifetime -= Elapsed / 2;
                if (m_particles[i].lifetime <= Time.Zero)
                {
                    float Angle = R.Next(0, 45);
                    float Speed = ((R.Next() % 50) + 50) / 3f;

                    float deltaX = (float)Math.Cos(Math.PI * (Angle - 90) / 180.0f) * Speed;
                    float deltaY = (float)Math.Sin(Math.PI * (Angle - 90) / 180.0f) * Speed;


                    m_particles[i].velocity = new Vector2f(
                        deltaX,
                        deltaY);
                    m_particles[i].lifetime = Time.FromMilliseconds((R.Next() % 2000) + 1000);
                    temp.Color = Color.White;
                    temp.Position = m_emitter;
                }
                temp.Position += m_particles[i].velocity * .125f;
                float ratio =
                    m_particles[i].lifetime.AsSeconds() / m_lifetime.AsSeconds();
                temp.Color.A = (byte)(ratio * 255);
                m_vertices[(uint)i] = temp;
            }
        }
        public void SetEmitter(Vector2f newEmitter)
        {
            m_emitter = newEmitter;
        }



    }
}
