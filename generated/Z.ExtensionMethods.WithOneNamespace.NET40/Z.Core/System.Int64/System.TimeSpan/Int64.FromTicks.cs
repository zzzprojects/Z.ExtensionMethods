namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns a  that represents a specified time, where the specification is in units of ticks.
        /// </summary>
        /// <param name="value">A number of ticks that represent a time.</param>
        /// <returns>An object that represents .</returns>
        public static TimeSpan FromTicks(this Int64 value)
        {
            return TimeSpan.FromTicks(value);
        }
    }


}