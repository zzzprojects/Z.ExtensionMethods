using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that converts the @this to an epoch time span.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a TimeSpan.</returns>
        public static TimeSpan ToEpochTimeSpan(this DateTime @this)
        {
            return @this.Subtract(new DateTime(1970, 1, 1));
        }
    }
