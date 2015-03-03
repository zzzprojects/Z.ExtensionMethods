using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a  that represents a specified number of minutes, where the specification is accurate to the nearest
        ///     millisecond.
        /// </summary>
        /// <param name="value">A number of minutes, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents .</returns>
        public static TimeSpan FromMinutes(this Double value)
        {
            return TimeSpan.FromMinutes(value);
        }
    }


}