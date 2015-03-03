using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Adds an offset to the value of an unsigned pointer.
        /// </summary>
        /// <param name="pointer">The unsigned pointer to add the offset to.</param>
        /// <param name="offset">The offset to add.</param>
        /// <returns>A new unsigned pointer that reflects the addition of  to .</returns>
        public static UIntPtr Add(this UIntPtr pointer, Int32 offset)
        {
            return UIntPtr.Add(pointer, offset);
        }
    }


}