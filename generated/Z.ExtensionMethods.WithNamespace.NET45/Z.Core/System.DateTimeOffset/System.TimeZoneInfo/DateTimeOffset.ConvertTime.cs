using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts a time to the time in a particular time zone.
        /// </summary>
        /// <param name="dateTimeOffset">The date and time to convert.</param>
        /// <param name="destinationTimeZone">The time zone to convert  to.</param>
        /// <returns>The date and time in the destination time zone.</returns>
        public static DateTimeOffset ConvertTime(this DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
        }
    }


}