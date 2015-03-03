using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Text;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that repeats the string a specified number of times.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="repeatCount">Number of repeats.</param>
        /// <returns>The repeated string.</returns>
        public static string Repeat(this string @this, int repeatCount)
        {
            if (@this.Length == 1)
            {
                return new string(@this[0], repeatCount);
            }

            var sb = new StringBuilder(repeatCount*@this.Length);
            while (repeatCount-- > 0)
            {
                sb.Append(@this);
            }

            return sb.ToString();
        }
    }


}