namespace Z.ExtensionMethods.ObjectExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to a nullable character.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a char?</returns>
        public static char? ToNullableChar(this object @this)
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToChar(@this);
        }
    }


}