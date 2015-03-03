using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the
        ///     equivalent  value.
        /// </summary>
        /// <param name="cy">An OLE Automation Currency value.</param>
        /// <returns>A  that contains the equivalent of .</returns>
        public static Decimal FromOACurrency(this Int64 cy)
        {
            return Decimal.FromOACurrency(cy);
        }
    }


}