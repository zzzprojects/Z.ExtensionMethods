namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to a nullable int 64.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a long?</returns>
        public static long? ToNullableInt64(this object @this)
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt64(@this);
        }
    }


}