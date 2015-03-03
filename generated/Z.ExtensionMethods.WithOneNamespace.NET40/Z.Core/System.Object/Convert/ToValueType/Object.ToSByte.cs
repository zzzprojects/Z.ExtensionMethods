namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to the s byte.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a sbyte.</returns>
        public static sbyte ToSByte(this object @this)
        {
            return Convert.ToSByte(@this);
        }
    }


}