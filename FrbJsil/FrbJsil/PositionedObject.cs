using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlatRedBall
{
    public class PositionedObject
    {
        public Vector3 Position;



        #region XML Docs
        /// <summary>
        /// The absolute X position.
        /// </summary>
        #endregion
        public float X
        {
            get { return Position.X; }
            set
            {
                Position.X = value;

#if DEBUG
                if (float.IsNaN(Position.X))
                {
                    throw new Exception("The X value has been set to an invalid number (float.NaN)");
                }
#endif

            }
        }

        #region XML Docs
        /// <summary>
        /// The absolute Y position.
        /// </summary>
        #endregion
        public float Y
        {
            get { return Position.Y; }
            set
            {
                Position.Y = value;

#if DEBUG
                if (float.IsNaN(Position.Y))
                {
                    throw new Exception("The Y value has been set to an invalid number (float.NaN)");
                }
#endif
            }
        }

        #region XML Docs
        /// <summary>
        /// The absolute Z position.
        /// </summary>
        #endregion
        public float Z
        {
            get { return Position.Z; }
            set
            {
                Position.Z = value;

#if DEBUG
                if (float.IsNaN(Position.Z))
                {
                    throw new Exception("The Z value has been set to an invalid number (float.NaN)");
                }
#endif
            }
        }


    }
}
