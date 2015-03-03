using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Retrieves the byte at a specified location in a specified array.
        /// </summary>
        /// <param name="array">An array.</param>
        /// <param name="index">A location in the array.</param>
        /// <returns>Returns the  byte in the array.</returns>
        public static Byte GetByte(this Array array, Int32 index)
        {
            return Buffer.GetByte(array, index);
        }
    }


}