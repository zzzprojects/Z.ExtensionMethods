using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int64 extension method that div rem.
        /// </summary>
        /// <param name="a">a to act on.</param>
        /// <param name="b">The Int64 to process.</param>
        /// <param name="result">[out] The result.</param>
        /// <returns>An Int64.</returns>
        public static Int64 DivRem(this Int64 a, Int64 b, out Int64 result)
        {
            return Math.DivRem(a, b, out result);
        }
    }


}