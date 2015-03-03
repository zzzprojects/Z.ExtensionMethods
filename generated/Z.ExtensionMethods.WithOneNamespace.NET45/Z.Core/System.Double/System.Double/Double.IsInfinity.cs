namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to negative or positive infinity.
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>true if  evaluates to  or ; otherwise, false.</returns>
        public static Boolean IsInfinity(this Double d)
        {
            return Double.IsInfinity(d);
        }
    }


}