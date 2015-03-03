public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid decimal.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid decimal, false if not.</returns>
        public static bool IsValidDecimal(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            decimal result;
            return decimal.TryParse(@this.ToString(), out result);
        }
    }
