namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Retrieves a reference to a specified .
        /// </summary>
        /// <param name="str">The string to search for in the intern pool.</param>
        /// <returns>A reference to  if it is in the common language runtime intern pool; otherwise, null.</returns>
        public static String IsInterned(this String str)
        {
            return String.IsInterned(str);
        }
    }


}