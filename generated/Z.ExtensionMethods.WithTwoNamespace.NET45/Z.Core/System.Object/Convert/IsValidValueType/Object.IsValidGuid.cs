namespace Z.ExtensionMethods.ObjectExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid System.Guid.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid System.Guid, false if not.</returns>
        public static bool IsValidGuid(this object @this)
        {
            Guid result;
            return Guid.TryParse(@this.ToString(), out result);
        }
    }


}