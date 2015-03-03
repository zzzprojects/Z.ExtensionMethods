using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Subtracts an offset from the value of an unsigned pointer.
        /// </summary>
        /// <param name="pointer">The unsigned pointer to subtract the offset from.</param>
        /// <param name="offset">The offset to subtract.</param>
        /// <returns>A new unsigned pointer that reflects the subtraction of  from .</returns>
        public static UIntPtr Subtract(this UIntPtr pointer, Int32 offset)
        {
            return UIntPtr.Subtract(pointer, offset);
        }
    }


}