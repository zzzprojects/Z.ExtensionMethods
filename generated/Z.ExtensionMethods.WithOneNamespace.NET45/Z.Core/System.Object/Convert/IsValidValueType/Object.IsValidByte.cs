namespace Z.ExtensionMethods
{

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid byte.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid byte, false if not.</returns>
        public static bool IsValidByte(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            byte result;
            return byte.TryParse(@this.ToString(), out result);
        }
    }


}