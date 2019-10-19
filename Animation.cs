using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Animation : Drawable
    {


        private const string CONTENT_DIRICTORY = "..\\Content\\Textures\\";
        public float Frame, speed;
        public Sprite sprite;
        public List<IntRect> frames = new List<IntRect>();

        Animation() { }

        public Animation(String file, int x, int y, int w, int h, int countX, int countY, float Speed)
        {
            Image image = new Image(CONTENT_DIRICTORY + file);
            Texture texture = new Texture(image);
            texture.Smooth = true;
            sprite = new Sprite(texture);
            sprite.Origin = new Vector2f(w / 2, h / 2);


            //
            Frame = 0;
            speed = Speed;
            for (int i = 0; i < countY; i++) {
                for (int j = 0; j < countX; j++)
                {
                        frames.Add(new IntRect(x + (j * w), y, w, h));
                }
                y += h;
                x = 0;
            }
            sprite.TextureRect = frames[0];
        }

        public void update()
        {
            Frame += speed;
            int n = frames.Count;
            if (Frame >= n) Frame -= n;
            if (n > 0) sprite.TextureRect = frames[(int)Frame];

            Program.Window.Draw(sprite);
        }

        public bool isEnd()
        {
            return Frame + speed >= frames.Count;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            throw new NotImplementedException();

        }
    }
};
