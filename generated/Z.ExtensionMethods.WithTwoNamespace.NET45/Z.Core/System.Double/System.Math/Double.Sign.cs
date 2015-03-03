using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a value indicating the sign of a double-precision floating-point number.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        ///     A number that indicates the sign of , as shown in the following table.Return value Meaning -1  is less than
        ///     zero. 0  is equal to zero. 1  is greater than zero.
        /// </returns>
        public static Int32 Sign(this Double value)
        {
            return Math.Sign(value);
        }
    }


}