public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid ulong.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid ulong, false if not.</returns>
        public static bool IsValidUInt64(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            ulong result;
            return ulong.TryParse(@this.ToString(), out result);
        }
    }
