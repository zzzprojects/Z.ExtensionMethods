using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Sets a range of elements in the  to zero, to false, or to null, depending on the element type.
        /// </summary>
        /// <param name="array">The  whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        public static void Clear(this Array array, Int32 index, Int32 length)
        {
            Array.Clear(array, index, length);
        }
    }
