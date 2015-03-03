using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid ushort.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid ushort, false if not.</returns>
        public static bool IsValidUShort(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            ushort result;
            return ushort.TryParse(@this.ToString(), out result);
        }
    }


}