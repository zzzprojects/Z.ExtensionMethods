using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.Text;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that extracts the UInt32 from the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The extracted UInt32.</returns>
        public static uint ExtractUInt32(this string @this)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < @this.Length; i++)
            {
                if (Char.IsDigit(@this[i]))
                {
                    sb.Append(@this[i]);
                }
            }

            return Convert.ToUInt32(sb.ToString());
        }
    }


}