namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts this object to an u long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to an ulong.</returns>
        public static ulong ToULongOrDefault(this object @this)
        {
            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (Exception)
            {
                return default(ulong);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to an u long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to an ulong.</returns>
        public static ulong ToULongOrDefault(this object @this, ulong defaultValue)
        {
            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to an u long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to an ulong.</returns>
        public static ulong ToULongOrDefault(this object @this, Func<ulong> defaultValueFactory)
        {
            try
            {
                return Convert.ToUInt64(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }
    }


}