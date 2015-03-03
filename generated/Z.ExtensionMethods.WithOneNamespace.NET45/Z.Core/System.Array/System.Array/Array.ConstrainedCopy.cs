namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Copies a range of elements from an  starting at the specified source index and pastes them to another
        ///     starting at the specified destination index.  Guarantees that all changes are undone if the copy does not
        ///     succeed completely.
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void ConstrainedCopy(this Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
        {
            Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }
    }


}