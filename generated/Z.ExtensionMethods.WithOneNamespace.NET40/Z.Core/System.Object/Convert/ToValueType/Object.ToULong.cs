namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to an u long.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an ulong.</returns>
        public static ulong ToULong(this object @this)
        {
            return Convert.ToUInt64(@this);
        }
    }


}