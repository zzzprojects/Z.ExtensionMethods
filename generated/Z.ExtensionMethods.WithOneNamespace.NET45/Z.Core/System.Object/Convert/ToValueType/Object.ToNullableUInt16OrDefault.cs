namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts this object to a nullable u int 16 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to an ushort?</returns>
        public static ushort? ToNullableUInt16OrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToUInt16(@this);
            }
            catch (Exception)
            {
                return default(ushort);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable u int 16 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to an ushort?</returns>
        public static ushort? ToNullableUInt16OrDefault(this object @this, ushort? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToUInt16(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable u int 16 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to an ushort?</returns>
        public static ushort? ToNullableUInt16OrDefault(this object @this, Func<ushort?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToUInt16(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }
    }


}