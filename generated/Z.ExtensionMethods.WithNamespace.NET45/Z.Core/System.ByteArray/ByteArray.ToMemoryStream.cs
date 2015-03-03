using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System.IO;

public static partial class Extensions
    {
        /// <summary>
        ///     A byte[] extension method that converts the @this to a memory stream.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a MemoryStream.</returns>
        public static MemoryStream ToMemoryStream(this byte[] @this)
        {
            return new MemoryStream(@this);
        }
    }


}