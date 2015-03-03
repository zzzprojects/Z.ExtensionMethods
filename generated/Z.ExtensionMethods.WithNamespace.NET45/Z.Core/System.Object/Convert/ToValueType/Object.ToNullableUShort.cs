using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts the @this to a nullable u short.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an ushort?</returns>
        public static ushort? ToNullableUShort(this object @this)
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToUInt16(@this);
        }
    }


}