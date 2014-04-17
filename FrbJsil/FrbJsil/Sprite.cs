using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlatRedBall
{
    public class Sprite : PositionedObject
    {

        float mTextureScale;
        
        public Texture2D mTexture;
        public Texture2D Texture
        {
            get { return mTexture; }
            set
            {
                mTexture = value;

                if (TextureScale > 0)
                {
                    UpdateScale();
                }
            }
        }



        public float ScaleX
        {
            get;
            set;
        }

        public float ScaleY
        {
            get;
            set;
        }


        public float TextureScale
        {
            get
            {
                return mTextureScale;
            }
            set
            {
                mTextureScale = value;
                UpdateScale();
            }
        }

        public Sprite()
        {
            // We're going to default TextureScale to 1 in FRBJSIL
            TextureScale = 1;


        }


        private void UpdateScale()
        {
            if (TextureScale > 0 && mTexture != null)
            {
                var pixelSize = TextureScale / 2.0f;

                ScaleX = mTexture.Width * pixelSize;// *(mVertices[1].TextureCoordinate.X - mVertices[0].TextureCoordinate.X);
                ScaleY = mTexture.Height * pixelSize;// *(mVertices[2].TextureCoordinate.Y - mVertices[1].TextureCoordinate.Y);
            }
        }




    }
}
