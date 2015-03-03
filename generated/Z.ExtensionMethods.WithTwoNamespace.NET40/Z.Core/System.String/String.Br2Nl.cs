using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that line break 2 newline.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A string.</returns>
        public static string Br2Nl(this string @this)
        {
            return @this.Replace("<br />", "\r\n").Replace("<br>", "\r\n");
        }
    }


}