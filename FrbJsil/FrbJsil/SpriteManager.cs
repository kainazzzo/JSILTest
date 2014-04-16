using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlatRedBall
{
    public static class SpriteManager
    {

        static List<Sprite> mOrderedByDistanceFromCameraSprites = new List<Sprite>();

        static internal List<Sprite> OrderedByDistanceFromCameraSprites
        {
            get { return mOrderedByDistanceFromCameraSprites; }
        }



        public static Sprite AddSprite(Texture2D texture)
        {
            Sprite newSprite = new Sprite();
            newSprite.Texture = texture;
            //newSprite.TimeCreated = TimeManager.CurrentTime;

            AddSprite(newSprite);
            return newSprite;
        }



        public static void AddSprite(Sprite spriteToAdd)
        {
//#if DEBUG

//            if (!FlatRedBallServices.IsThreadPrimary())
//            {
//                throw new InvalidOperationException("Objects can only be added on the primary thread");
//            }
//#endif
            if (spriteToAdd != null)
            {
                // Vic says:  This fixes a bug in Glue that I discovered while working on
                // Udder Chaos.  Sometimes objects are removed after they cycle.  If this happens
                // then the removed Sprite's JustCycled will stay true.  This can cause Sprites to
                // be removed immediately after they are added IF the Sprite is recycled.  
                //spriteToAdd.mJustCycled = false;
                //spriteToAdd.mJustChangedFrame = false;

//#if DEBUG
//                if (mAutomaticallyUpdatedSprites.Contains(spriteToAdd))
//                {
//                    throw new InvalidOperationException(
//                        "This Sprite has already been added to the engine.  This exception is thrown to prevent bugs that can occur from a double-add.");
//                }
//#endif

                //mAutomaticallyUpdatedSprites.Add(spriteToAdd);

                //spriteToAdd.mAutomaticallyUpdated = true;

                //if (mOrderedSortType == SortType.Z)
                //{
                //    mOrderedByDistanceFromCameraSprites.AddSortedZAscending(spriteToAdd);
                //}
                //else
                {
                    mOrderedByDistanceFromCameraSprites.Add(spriteToAdd);
                }

            }
        }

    }
}
