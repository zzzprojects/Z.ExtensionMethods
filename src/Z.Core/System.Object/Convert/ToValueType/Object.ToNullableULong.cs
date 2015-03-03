using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to a nullable u long.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an ulong?</returns>
        public static ulong? ToNullableULong(this object @this)
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToUInt64(@this);
        }
    }
