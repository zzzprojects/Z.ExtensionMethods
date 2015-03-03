using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the cosine of the specified angle.
        /// </summary>
        /// <param name="d">An angle, measured in radians.</param>
        /// <returns>The cosine of . If  is equal to , , or , this method returns .</returns>
        public static Double Cos(this Double d)
        {
            return Math.Cos(d);
        }
    }


}