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
    class Menu : Levels
    {
        // View view = new View(new FloatRect(0, 0, 1280, 720));
        Color CopyColor;
        public List<MenuRectShips> RectShips = new List<MenuRectShips>();

        public List<MenuRectButtons> RectButtons = new List<MenuRectButtons>();

        public MenuRectMainShip MainShip;
        private int listShips;

        public Menu()
        {
            IsOpen = true;
        }

        public void Load()
        {
            MainShip = new MenuRectMainShip();
            listShips = 1;
            Program.content.LoadListShips1();
        }

        public void Update()
        {
            CopyColor = Program.content.GetShip9_lock().Color;
            Program.Window.Draw(Program.content.GetMenuLevels());
            Program.Window.Draw(Program.content.GetMenuShips());
            Program.Window.Draw(Program.content.GetMenuTable());
            Program.Window.Draw(Program.content.GetCircle1());
            Program.Window.Draw(Program.content.GetCircle2());
            Program.Window.Draw(Program.content.GetCircle3());
            Program.Window.Draw(Program.content.GetCircle4());
            Program.Window.Draw(Program.content.GetMenuButton());
            Program.Window.Draw(Program.content.GetTextPlay());
            Program.Window.Draw(Program.content.GetListUpButton());
            Program.Window.Draw(Program.content.GetListDownButton());

            //Program.content.LoadListShips1();

            if (listShips == 1)
            {
                Program.content.LoadListShips1();
            }
            if (listShips == 2)
            {
                Program.content.LoadListShips2();
            }

            if (listShips == 1)
            {
                // Program.content.LoadListShips1();
                Program.Window.Draw(Program.content.GetShip1_lock());
                Program.Window.Draw(Program.content.GetShip2_lock());
                Program.Window.Draw(Program.content.GetShip3_lock());
                Program.Window.Draw(Program.content.GetShip4_lock());
                Program.Window.Draw(Program.content.GetShip5_lock());
                Program.Window.Draw(Program.content.GetShip6_lock());

            }
            else
            {
                Program.Window.Draw(Program.content.GetShip7_lock());
                Program.Window.Draw(Program.content.GetShip8_lock());
                Program.Window.Draw(Program.content.GetShip9_lock());
            }

            Program.Window.Draw(Program.menu.MainShip.SpriteShip);


            for (int i = 0; i < 3; i++)
            {
                Program.Window.Draw(Program.content.sMenuRectHp[i]);
                Program.Window.Draw(Program.content.sMenuRectDmg[i]);
                Program.Window.Draw(Program.content.sMenuRectSpd[i]);
            }

            foreach (MenuRectShips RectShip in Program.menu.RectShips.ToList())
            {
                if (Contains(RectShip.SpriteRect, Mouse.GetPosition(Program.Window).X, Mouse.GetPosition(Program.Window).Y))
                {
                    Program.Window.Draw(RectShip.SpriteRect);
                    


                    RectShip.SpriteRect.Color = Color.Red;

                    if (Mouse.IsButtonPressed(Mouse.Button.Left))
                    {
                        MainShip.SpriteShip = RectShip.SpriteShip;
                        MainShip.SpriteShip.Position = new Vector2f(640, 360);
                    }
                }
                else RectShip.SpriteRect.Color = Program.content.GetColorButtonUp().Color;
            }


            foreach (MenuRectButtons RectButtons in Program.menu.RectButtons.ToList())
            {
                if (Contains(RectButtons.SpriteRect, Mouse.GetPosition(Program.Window).X, Mouse.GetPosition(Program.Window).Y))
                {
                    Program.Window.Draw(RectButtons.SpriteRect);

                    if (RectButtons.Name == "ButtonUp" || RectButtons.Name == "ButtonDown")
                    {
                        RectButtons.SpriteRect.Color = Color.Red;
                    }
                    else
                    {
                        RectButtons.SpriteRect.Color = new Color(0, 100, 255);
                    }


                    if (Mouse.IsButtonPressed(Mouse.Button.Left))
                    {
                        //Событие что нажалось в меню
                        //Если нажалось кнопка смены листа то

                        if (RectButtons.Name == "ButtonUp")
                        {
                            listShips = 1;
                        }
                        if (RectButtons.Name == "ButtonDown")
                        {
                            listShips = 2;
                        }
                        if (RectButtons.Name == "ButtonPlay")
                        {
                            Program.level1.IsOpen = true;
                            Program.menu.IsOpen = false;
                        }
                    }

                }
                else RectButtons.SpriteRect.Color = Program.content.GetColorButtonUp().Color;
            }
        }

        public bool Contains(Sprite sprite, int x, int y)
        {
            int num = (int)Math.Min(sprite.Position.X, sprite.Position.X + sprite.Texture.Size.X);
            int num2 = (int)Math.Max(sprite.Position.X, sprite.Position.X + sprite.Texture.Size.X);
            int num3 = (int)Math.Min(sprite.Position.Y, sprite.Position.Y + sprite.Texture.Size.Y);
            int num4 = (int)Math.Max(sprite.Position.Y, sprite.Position.Y + sprite.Texture.Size.Y);
            return ((x >= num) && ((x < num2) && ((y >= num3) && (y < num4))));
        }
        public bool Contains(IntRect this1, int x, int y, Sprite sprite)
        {
            int num = Math.Min(this1.Left, this1.Left + this1.Width);
            int num2 = Math.Max(this1.Left, this1.Left + this1.Width);
            int num3 = Math.Min(this1.Top, this1.Top + this1.Height);
            int num4 = Math.Max(this1.Top, this1.Top + this1.Height);
            return ((x >= num) && ((x < num2) && ((y >= num3) && (y < num4))));
        }



    }
}