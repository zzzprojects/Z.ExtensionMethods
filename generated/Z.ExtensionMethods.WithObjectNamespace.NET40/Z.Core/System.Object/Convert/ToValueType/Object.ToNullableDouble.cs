namespace Z.ExtensionMethods.ObjectExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to a nullable double.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a double?</returns>
        public static double? ToNullableDouble(this object @this)
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToDouble(@this);
        }
    }


}