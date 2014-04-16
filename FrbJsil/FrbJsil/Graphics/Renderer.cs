using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlatRedBall.Graphics
{
    public static class Renderer
    {
        static SpriteBatch mSpriteBatch;



        internal static void Initialize(IGraphicsDeviceService graphics)
        {
            mSpriteBatch = new SpriteBatch(graphics.GraphicsDevice);
        }


        public static void Draw()
        {
            
            DrawCamera(null, null, null);
        }

        static void DrawCamera(object first, object second, object third)
        {
            foreach (var sprite in SpriteManager.OrderedByDistanceFromCameraSprites)
            {
                mSpriteBatch.Begin();
                mSpriteBatch.Draw(sprite.Texture, new Vector2(sprite.X, sprite.Y), Color.White);
                mSpriteBatch.End();

            }
        }
    }
}
