using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to positive infinity.
        /// </summary>
        /// <param name="f">A single-precision floating-point number.</param>
        /// <returns>true if  evaluates to ; otherwise, false.</returns>
        public static Boolean IsPositiveInfinity(this Single f)
        {
            return Single.IsPositiveInfinity(f);
        }
    }
