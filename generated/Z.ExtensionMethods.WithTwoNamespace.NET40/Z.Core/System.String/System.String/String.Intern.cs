using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Retrieves the system&#39;s reference to the specified .
        /// </summary>
        /// <param name="str">A string to search for in the intern pool.</param>
        /// <returns>
        ///     The system&#39;s reference to , if it is interned; otherwise, a new reference to a string with the value of .
        /// </returns>
        public static String Intern(this String str)
        {
            return String.Intern(str);
        }
    }


}