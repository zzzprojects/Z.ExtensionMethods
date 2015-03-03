using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to a date time.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a DateTime.</returns>
        public static DateTime ToDateTime(this object @this)
        {
            return Convert.ToDateTime(@this);
        }
    }
