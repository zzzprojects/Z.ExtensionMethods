using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid short.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid short, false if not.</returns>
        public static bool IsValidShort(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            short result;
            return short.TryParse(@this.ToString(), out result);
        }
    }


}