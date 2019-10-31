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
    class Game : Rand
    {
        private static int CountAsteroids = 0;
        private static int CountEnemies = 0;
        Clock bullet_clock = new Clock();
        Clock clock = new Clock();
        //private float bullet_cooldown;
        Random rnd2 = new Random();

        public void Update(Ship ship, List<Entity> entities)
        {
            float time = clock.ElapsedTime.AsMicroseconds();
            clock.Restart();
            time = time / 10000;

            foreach (Entity entity in entities.ToList())
            {

                entity.Update(time);
                if (entity.animation != null)
                {
                    if (entity.GetName() == "Explosion")
                    {
                        entity.animation.update();
                        entity.animation.Draw();
                        if (entity.animation.isEnd()) entity.SetHealth(0);
                    }
                   // entity.animation.update();
                   // entity.animation.Draw();
                }
                entity.Draw();
                if (entity.GetName() == "PlayerShip" && entity.GetHealth() <= 0)
                {
                    Ship Ship = new Ship("SpaceShip1.png", 500, 500, 106, 80);                  //Загружаем корабль
                    entities.Add(Ship);
                }


                if (entity.GetHealth() <= 0)
                {
                    entities.Remove(entity);
                }
            }

            for (int i = 0; i < entities.Count; i++)
            {
                for (int j = 0; j < entities.Count; j++)
                {
                    if (entities[j].GetName() == "Bullet" && (entities[i].GetName() == "Asteroid" || entities[i].GetName() == "EnemyShip" |entities[i].GetName() == "PlayerShip"))
                        if (IsCollide(entities[i].sprite, entities[j].sprite))
                        {
                            Animation AnimationExplosive1 = new Animation(Program.content.GetsExplosion(), 0, 0, 192, 192, 64, 0.8f);
                            Entity e = new Entity();
                            e.Settings(AnimationExplosive1, "Explosion", entities[i].GetX(), entities[i].GetY(), 0, 0.1F, 0.15f);
                            entities.Add(e);



                            //Новый астероид
                            //
                            //


                            entities[i].damage(Program.Ship.GetDamage()); entities[j].SetHealth(0);
                        }
                    if (entities[i].GetName() == "PlayerShip" && (entities[j].GetName() == "EnemyShip" || entities[j].GetName() == "Asteroid")) 
                        if (IsCollide(entities[i].sprite, entities[j].sprite))
                        {
                            Animation AnimationExplosive1 = new Animation(Program.content.GetsExplosion(), 0, 0, 192, 192, 64, 0.8f);
                            Entity e = new Entity();
                            e.Settings(AnimationExplosive1, "Explosion", entities[i].GetX(), entities[i].GetY(), 0, 0.4F, 0.15f);
                            entities.Add(e);
                            entities[i].damage(50); entities[j].SetHealth(0);                             //Урон при столкновении нашему кораблю 50!!!!!! Можно изменить
                        }


                }
            }
        }

        private static bool IsCollide(Sprite first, Sprite second)
        {
            Vector2f firstRect = new Vector2f(first.TextureRect.Width, first.TextureRect.Width);
            firstRect.X *= first.Scale.X;
            firstRect.Y *= first.Scale.Y;

            Vector2f secondRect = new Vector2f(second.TextureRect.Width, second.TextureRect.Width);
            secondRect.X *= second.Scale.X;
            secondRect.Y *= second.Scale.Y;

            float r1 = (firstRect.X + firstRect.Y) / 4;
            float r2 = (secondRect.X + secondRect.Y) / 4;
            float xd = first.Position.X - second.Position.X;
            float yd = first.Position.Y - second.Position.Y;

            return (Math.Sqrt(xd * xd + yd * yd) <= r1 + r2);
        }


        public void CreateAsteroid(List<Entity> entities, int count)
        {
            int b = rnd2.Next(1, 100);
            if (b == 1)
            {
                if (CountAsteroids != count)
                {
                    Asteroid a = new Asteroid();
                    entities.Add(a);

                    CountAsteroids++;
                }
            }
        }



        public void Enemy(List<Entity> entities, int count)
        {
            
            int b = rnd.Next(1, 100);
            if (b == 1)
            {
                if (CountEnemies != count)
                {
                    int Choose1, Choose2, a1, a2;
                    Choose1 = rnd.Next(0, 2);
                    if (Choose1 == 1)
                    {
                        a1 = rnd.Next(1, Program.WindowWidth);
                        Choose2 = rnd.Next(0, 2);
                        if (Choose2 == 1)                       //Если 1 то сверху
                        {
                            a2 = 0;
                        }
                        else                                    //Если 2 то снизу
                        {
                            a2 = Program.WindowHeight;
                        }
                    }
                    else
                    {
                        a2 = rnd.Next(1, Program.WindowHeight);
                        Choose2 = rnd.Next(0, 2);
                        if (Choose2 == 1)                       //Если 1 то слева
                        {
                            a1 = 0;
                        }
                        else                                    //Если 2 то справа
                        {
                            a1 = Program.WindowWidth;
                        }
                    }


                    //Теория вер
                    //Если a = 1; стрелок Name = "Стрелок"
                    //Если камикадзе



                    EnemyShip a = new EnemyShip(Program.content.GetsEnemy(),a1,a2,0.5f); // нейм
                    entities.Add(a);
                    CountEnemies++;
                }
            }
        }
    }

}
