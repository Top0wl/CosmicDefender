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
    class Menu : Levels
    {
        // View view = new View(new FloatRect(0, 0, 1280, 720));
        Color CopyColor;
        public List<MenuRectShips> RectShips = new List<MenuRectShips>();
        public MenuRectMainShip MainShip;

        public Menu()
        {
            IsOpen = true;
        }

        public void Load()
        {
            CopyColor = Program.content.GetShip1_lock().Color;
            MainShip = new MenuRectMainShip();
        }

        public void Update()
        {
            Program.Window.Draw(Program.content.GetMenuLevels());
            Program.Window.Draw(Program.content.GetMenuShips());
            Program.Window.Draw(Program.content.GetMenuTable());
            Program.Window.Draw(Program.content.GetCircle1());
            Program.Window.Draw(Program.content.GetCircle2());
            Program.Window.Draw(Program.content.GetCircle3());
            Program.Window.Draw(Program.content.GetCircle4());
            Program.Window.Draw(Program.content.GetMenuButton());
            Program.Window.Draw(Program.content.GetTextPlay());
            Program.Window.Draw(Program.content.GetShip1_lock());
            Program.Window.Draw(Program.content.GetShip2_lock());
            Program.Window.Draw(Program.content.GetShip3_lock());
            Program.Window.Draw(Program.content.GetShip4_lock());
            Program.Window.Draw(Program.content.GetShip5_lock());
            Program.Window.Draw(Program.content.GetShip6_lock());
            Program.Window.Draw(Program.content.GetShip7_lock());
            Program.Window.Draw(Program.content.GetShip8_lock());
            Program.Window.Draw(Program.content.GetShip9_lock());

            Program.Window.Draw(Program.menu.MainShip.SpriteShip);

            for (int i = 0; i < 3; i++)
            {
                Program.Window.Draw(Program.content.sMenuRectHp[i]);
                Program.Window.Draw(Program.content.sMenuRectDmg[i]);
                Program.Window.Draw(Program.content.sMenuRectSpd[i]);
            }




                foreach (MenuRectShips RectShip in Program.menu.RectShips)
                {
                    if (Contains(RectShip.SpriteRect, Mouse.GetPosition(Program.Window).X, Mouse.GetPosition(Program.Window).Y))
                    {
                        RectShip.SpriteRect.Color = Color.Yellow;
                        if (Mouse.IsButtonPressed(Mouse.Button.Left))
                        {
                            MainShip.SpriteShip = RectShip.SpriteShip;
                            MainShip.SpriteShip.Position = new Vector2f(590, 320);
                        }
                    }
                    else RectShip.SpriteRect.Color = Program.content.GetShip9_lock().Color;
                }
    



           /* if (Contains(Program.content.GetShip1_lock(), Mouse.GetPosition(Program.Window).X, Mouse.GetPosition(Program.Window).Y))
            {
            Program.content.GetShip1_lock().Color = Color.Yellow;
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {

            }
            }
            else Program.content.GetShip1_lock().Color = CopyColor;
            */



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
