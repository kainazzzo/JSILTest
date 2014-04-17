using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlatRedBall
{
    public class Camera : PositionedObject
    {
        public static Camera Main
        {
            get;
            internal set;
        }



        public virtual Matrix TransformationMatrix
        {
            get
            {
                return //RotationMatrix * 
                    Matrix.CreateTranslation(Position);
            }
            set
            {
                // Get position
#if FRB_MDX
                Position = value.Translation();
#else
                Position = value.Translation;
#endif
                // Get scale
                Vector3 finalScale = new Vector3(
                    (float)System.Math.Sqrt((double)(
                        value.M11 * value.M11 +
                        value.M12 * value.M12 +
                        value.M13 * value.M13)),
                    (float)System.Math.Sqrt((double)(
                        value.M21 * value.M21 +
                        value.M22 * value.M22 +
                        value.M23 * value.M23)),
                    (float)System.Math.Sqrt((double)(
                        value.M31 * value.M31 +
                        value.M32 * value.M32 +
                        value.M33 * value.M33)));

                // Get rotation
                Vector3 finalRot = new Vector3(
                     (float)System.Math.Atan2(value.M23 / finalScale.Y, value.M33 / finalScale.Z),
                     -(float)System.Math.Asin(value.M13 / finalScale.X),
                     (float)System.Math.Atan2(value.M12 / finalScale.X, value.M11 / finalScale.X));

#if FRB_MDX
                if (finalRot.X < 0) finalRot.X += (float)System.Math.PI;
                if (finalRot.Y < 0) finalRot.Y += (float)System.Math.PI;
                if (finalRot.Z < 0) finalRot.Z += (float)System.Math.PI;
#else
                if (finalRot.X < 0) finalRot.X += MathHelper.TwoPi;
                if (finalRot.Y < 0) finalRot.Y += MathHelper.TwoPi;
                if (finalRot.Z < 0) finalRot.Z += MathHelper.TwoPi;
#endif

                //mRotationX = finalRot.X;
                //mRotationY = finalRot.Y;
                //// Forces the rotation matrix to update
                //RotationZ = finalRot.Z;
            }
        }


    }
}
