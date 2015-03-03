using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Reverses the sequence of the elements in the entire one-dimensional .
        /// </summary>
        /// <param name="array">The one-dimensional  to reverse.</param>
        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        ///     Reverses the sequence of the elements in a range of elements in the one-dimensional .
        /// </summary>
        /// <param name="array">The one-dimensional  to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        public static void Reverse(this Array array, Int32 index, Int32 length)
        {
            Array.Reverse(array, index, length);
        }
    }


}