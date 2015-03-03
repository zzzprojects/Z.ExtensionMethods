using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A byte[] extension method that resizes the byte[].
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="newSize">Size of the new.</param>
        /// <returns>A byte[].</returns>
        public static byte[] Resize(this byte[] @this, int newSize)
        {
            Array.Resize(ref @this, newSize);
            return @this;
        }
    }
