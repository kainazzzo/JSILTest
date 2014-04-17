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
            
            DrawCamera(Camera.Main, null, null);
        }

        static void DrawCamera(Camera camera, object second, object third)
        {
            var transformationMatrix = camera.TransformationMatrix;
            transformationMatrix = Matrix.Invert(transformationMatrix);

            // In this coordinate system, negative Y is up, so let's flip it to get to FRB coords
            transformationMatrix.M42 = -transformationMatrix.M42;

            // We also have to account for the top left of the screen not being 
            // the origin
            float xToAdd = mSpriteBatch.GraphicsDevice.Viewport.Width / 2.0f;
            float yToAdd = mSpriteBatch.GraphicsDevice.Viewport.Height / 2.0f;

            transformationMatrix.M41 += xToAdd;
            transformationMatrix.M42 += yToAdd;

            foreach (var sprite in SpriteManager.OrderedByDistanceFromCameraSprites)
            {

                //Begins a sprite batch operation using deferred sort and default state objects
                //     (BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.None,
                //     RasterizerState.CullCounterClockwise).
                mSpriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.None,
                    RasterizerState.CullCounterClockwise, null, transformationMatrix);

                float left = sprite.X - sprite.ScaleX;
                float top = -sprite.Y - sprite.ScaleY;


                float actualWidth = sprite.ScaleX * 2;
                float ratio = actualWidth;
                if (sprite.Texture != null)
                {
                    ratio = actualWidth / sprite.Texture.Width;
                }

                mSpriteBatch.Draw(sprite.Texture, new Vector2(left, top), null, Color.White, 0, Vector2.Zero, ratio,
                    SpriteEffects.None, 0);
                mSpriteBatch.End();

            }
        }
    }
}
