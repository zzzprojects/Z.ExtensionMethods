using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the number of bytes in the specified array.
        /// </summary>
        /// <param name="array">An array.</param>
        /// <returns>The number of bytes in the array.</returns>
        public static Int32 ByteLength(this Array array)
        {
            return Buffer.ByteLength(array);
        }
    }


}