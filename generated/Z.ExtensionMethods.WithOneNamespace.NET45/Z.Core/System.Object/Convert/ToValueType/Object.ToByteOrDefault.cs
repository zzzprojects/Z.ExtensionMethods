namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts this object to a byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a byte.</returns>
        public static byte ToByteOrDefault(this object @this)
        {
            try
            {
                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return default(byte);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a byte.</returns>
        public static byte ToByteOrDefault(this object @this, byte defaultValue)
        {
            try
            {
                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a byte.</returns>
        public static byte ToByteOrDefault(this object @this, Func<byte> defaultValueFactory)
        {
            try
            {
                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }
    }


}