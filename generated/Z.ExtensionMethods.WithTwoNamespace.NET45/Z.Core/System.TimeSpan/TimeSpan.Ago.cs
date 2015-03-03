using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A TimeSpan extension method that substract the specified TimeSpan to the current DateTime.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The current DateTime with the specified TimeSpan substracted from it.</returns>
        public static DateTime Ago(this TimeSpan @this)
        {
            return DateTime.Now.Subtract(@this);
        }
    }


}