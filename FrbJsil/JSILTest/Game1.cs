using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using FlatRedBall;

namespace JSILTest
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            FlatRedBallServices.InitializeFlatRedBall(this, graphics);
            
            mTexture = Content.Load<Texture2D>("chickennugents");

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var sprite = SpriteManager.AddSprite(mTexture);

                sprite.X = -200 + 400 * (float)random.NextDouble();
                sprite.Y = -200 + 400 * (float)random.NextDouble();

                sprite.TextureScale = .1f;
            }

            base.Initialize();
        }

        private Texture2D mTexture;
        
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            FlatRedBallServices.Update(gameTime );

            
            //Camera.Main.Y++;

            // TODO: Add your update logic here
            

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            FlatRedBallServices.Draw();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
