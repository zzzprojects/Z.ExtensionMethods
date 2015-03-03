using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts this object to a nullable boolean or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a bool?</returns>
        public static bool? ToNullableBooleanOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToBoolean(@this);
            }
            catch (Exception)
            {
                return default(bool);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable boolean or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a bool?</returns>
        public static bool? ToNullableBooleanOrDefault(this object @this, bool? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToBoolean(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable boolean or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a bool?</returns>
        public static bool? ToNullableBooleanOrDefault(this object @this, Func<bool?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToBoolean(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }
    }


}