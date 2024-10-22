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
    class Game : Rand
    {
        public static int CountAsteroids = 0;
        public static int CountEnemies = 0;
        public static bool isBoss = false;
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
                }

                entity.Draw();

                if (entity.GetName() == "PlayerShip" && entity.GetHealth() <= 0)
                {
                    Program.menu.IsOpen = true;

                    foreach (Level level in Program.levels.ToList())
                    {
                        if (level.IsOpen == true)
                        {
                            level.IsOpen = false;
                        }
                    }

                    foreach (Level level in Program.levels.ToList())
                    {
                        if (level.IsOpen == true)
                        {
                            level.IsOpen = false;
                        }
                    }

                    entities.Clear();



                    Ship Ship = new Ship(Program.menu.MainShip.SpriteShip, 500, 500, Program.menu.MainShip.Damage, Program.menu.MainShip.Speed, Program.menu.MainShip.Shoot_speed, Program.menu.MainShip.Health, Program.menu.MainShip.CountGuns);
                    //Ship Ship = new Ship(Program.menu.MainShip.SpriteShip, 500, 500, 25, 1.5f, .2f, 100);                  //Загружаем корабль
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
                    if (entities[j].GetName() == "Bullet" && (entities[i].GetName() == "Asteroid" || entities[i].GetName() == "ShootShip" ||
                        entities[i].GetName() == "Bomber" || entities[i].GetName() == "PlayerShip" || entities[i].GetName() == "MiniBoss" || entities[i].GetName().IndexOf("Boss") > -1))                                        //Найден косяк, урон для пули общий - урон нашего корабля.
                                                                                                                                                                                                                       //Если потом добавлять других врагов с уроном побольше, чем у обычных, то произойдёт бан

                        //if(entities.Global)


                        if (IsCollide(entities[i].sprite, entities[j].sprite))
                        {


                            Animation AnimationExplosive1 = new Animation(Program.content.GetsExplosion(), 0, 0, 192, 192, 64, 2f);
                            Entity e = new Entity();
                            e.Settings(AnimationExplosive1, "Explosion", entities[j].GetX(), entities[j].GetY(), 0, 0.15F, 0.15f);
                            entities.Add(e);

                            //Новый астероид
                            //
                            //

                            entities[i].damage(Program.Ship.GetDamage()); entities[j].SetHealth(0);

                            //Выпадение бонуса
                            if (entities[i].GetName() == "Asteroid" && entities[i].GetHealth() == 0)
                            {
                                int b = rnd.Next(1, 100);
                                if (b >= 1 && b <= 30)
                                {
                                    Bonus a = new Bonus(Program.content.GetsB_Health(), entities[j].GetX(), entities[j].GetY(), "B_Health");
                                    entities.Add(a);
                                }
                                
                            }

                            if (entities[i].GetHealth() <= 0)
                            {
                                Animation AnimationExplosive2 = new Animation(Program.content.GetsExplosion(), 0, 0, 192, 192, 64, 0.8f);
                                Entity q = new Entity();

                                if (entities[i].GetName().IndexOf("Boss") > -1)
                                {
                                    q.Settings(AnimationExplosive2, "Explosion", entities[i].GetX(), entities[i].GetY(), 0, 1f, 0.15f);
                                }
                                else
                                {
                                    q.Settings(AnimationExplosive2, "Explosion", entities[i].GetX(), entities[i].GetY(), 0, 0.4F, 0.15f);
                                }
                                entities.Add(q);
                            }

                        }
                    if (entities[i].GetName() == "PlayerShip" && (entities[j].GetName() == "ShootShip" || entities[j].GetName() == "Asteroid" || entities[j].GetName() == "Bomber" || entities[j].GetName() == "MiniBoss" || entities[j].GetName().IndexOf("Boss") > -1))
                        if (IsCollide(entities[i].sprite, entities[j].sprite))
                        {
                            Animation AnimationExplosive1 = new Animation(Program.content.GetsExplosion(), 0, 0, 192, 192, 64, 0.8f);
                            Entity e = new Entity();
                            e.Settings(AnimationExplosive1, "Explosion", entities[i].GetX(), entities[i].GetY(), 0, 0.4F, 0.15f);
                            entities.Add(e);

                            if (entities[j].GetName() == "ShootShip" || entities[j].GetName() == "Asteroid")
                            {
                                entities[i].damage(50);
                                entities[j].SetHealth(0);

                                //Выпадение бонуса
                                if (entities[j].GetName() == "Asteroid")
                                {
                                    int b = rnd.Next(1, 100);
                                    if (b >= 1 && b <= 10)
                                    {
                                        Bonus a = new Bonus(Program.content.GetsB_Health(), entities[j].GetX(), entities[j].GetY(), "B_Health");
                                        entities.Add(a);
                                    }
                                }
                            }                                   //Урон при столкновении нашему кораблю 50!!!!!! Можно изменить

                            if (entities[j].GetName() == "Bomber")
                            {
                                entities[i].damage(100);
                                entities[j].SetHealth(0);
                            }

                            if (entities[j].GetName() == "MiniBoss")
                            {
                                entities[i].damage(100);
                                entities[j].damage(70);
                            }
                            if (entities[j].GetName().IndexOf("Boss") > -1)
                            {
                                entities[i].damage(300);
                            }

                        }
                    //Поднятие бонуса
                    if (entities[i].GetName() == "PlayerShip" && (entities[j].GetName() == "B_Health"))
                        if (IsCollide(entities[i].sprite, entities[j].sprite))
                        {
                            if (entities[j].GetName() == "B_Health")
                            {
                                entities[i].SetHealth(100);                             //max HP ????????
                            }

                            entities[j].SetHealth(0);
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

        #region Create Objects

        #region Asteroids

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

        #endregion

        #region Enemies

        public void Enemy(List<Entity> entities, int count, Boss boss)
        {
            int b = rnd.Next(1, 100);
            if (b == 1)
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
                if (CountEnemies != count)
                {

                    b = rnd.Next(1, 10);
                    string name;
                    if (b >= 1 && b <= 3)
                        name = "Bomber";
                    else if (b == 4)
                        name = "MiniBoss";
                    else
                        name = "ShootShip";

                    EnemyShip a = new EnemyShip();

                    if (name == "ShootShip")
                    {
                         a = new EnemyShip(Program.content.GetsShootShip(), a1, a2, 0.5f, name, 1, false, 0.4f);
                    }

                    if (name == "Bomber")
                    { 
                        a = new EnemyShip(Program.content.GetsBomber(), a1, a2, 1.8f, name, 0, false, 0.4f);
                    }

                    if (name == "MiniBoss")
                    {
                        a = new EnemyShip(Program.content.GetMiniBoss(), a1, a2, 0.3f, name, 4, false, 0.4f);
                        a.SetHealth(400);
                    }

                    entities.Add(a);
                    CountEnemies++;

                }
                else
                {
                    if (CountEnemies == count && isBoss == false)
                    {
                        entities.Add(boss);
                        isBoss = true;
                    }
                }
            }
        }

        #endregion

        #endregion

        public int GetCountEnemies()
        {
            return CountEnemies;
        }

    }

}
