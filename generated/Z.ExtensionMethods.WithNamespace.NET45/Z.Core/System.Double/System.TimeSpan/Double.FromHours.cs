using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a  that represents a specified number of hours, where the specification is accurate to the nearest
        ///     millisecond.
        /// </summary>
        /// <param name="value">A number of hours accurate to the nearest millisecond.</param>
        /// <returns>An object that represents .</returns>
        public static TimeSpan FromHours(this Double value)
        {
            return TimeSpan.FromHours(value);
        }
    }


}