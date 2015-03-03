namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that elapsed the given datetime.
        /// </summary>
        /// <param name="datetime">The datetime to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }
    }


}