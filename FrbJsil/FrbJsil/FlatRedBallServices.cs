using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using FlatRedBall.Graphics;

namespace FlatRedBall
{
    public static class FlatRedBallServices
    {
        public static void InitializeFlatRedBall(Game game, GraphicsDeviceManager graphics)
        {
            Renderer.Initialize(graphics);

            Camera.Main = new Camera();
        }



        public static void Update(GameTime gameTime)
        {

        }



        public static void Draw()
        {
            UpdateDependencies();

            RenderAll();
        }


        public static void UpdateDependencies()
        {


        }


        public static void RenderAll()
        {
            Renderer.Draw();

        }



    }
}
