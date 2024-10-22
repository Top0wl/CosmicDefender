﻿using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicDefender
{
    class Animation : Entity

    {
        public float Frame, Speed;
        public Sprite sprite;
        public List<IntRect> frames = new List<IntRect>();

        Animation() { }

        public Animation(Sprite _sprite, int x, int y, int w, int h, int countX, int countY, float speed)
        {
            sprite = new Sprite(_sprite);
            sprite.Origin = new Vector2f(w / 2, h / 2);
            Frame = 0;
            Speed = speed;
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

        public Animation(Sprite _sprite, int x, int y, int w, int h, int count, float speed)
        {
            sprite = new Sprite(_sprite);
            sprite.Origin = new Vector2f(w / 2, h / 2);
            Speed = speed;
            Frame = 0;
            for (int i = 0; i < count; i++)
            {
                frames.Add(new IntRect(x + (i * w), y, w, h));
            }
        }


        public void update()
        {
            Frame += Speed;
            int n = frames.Count;
            if (Frame >= n) Frame -= n;
            if (n > 0)
                sprite.TextureRect = frames[(int)Frame];
        }

        public bool isEnd()
        {
            return Frame + Speed >= frames.Count;
        }

        public override void Draw()
        {
            sprite.Position = new Vector2f(X, Y);
            Program.Window.Draw(sprite);
        }
    }
};
