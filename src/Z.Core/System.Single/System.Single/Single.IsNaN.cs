using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a value that indicates whether the specified value is not a number ().
        /// </summary>
        /// <param name="f">A single-precision floating-point number.</param>
        /// <returns>true if  evaluates to not a number (); otherwise, false.</returns>
        public static Boolean IsNaN(this Single f)
        {
            return Single.IsNaN(f);
        }
    }
