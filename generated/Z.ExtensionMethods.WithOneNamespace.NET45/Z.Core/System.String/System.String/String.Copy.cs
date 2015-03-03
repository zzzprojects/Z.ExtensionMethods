namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Creates a new instance of  with the same value as a specified .
        /// </summary>
        /// <param name="str">The string to copy.</param>
        /// <returns>A new string with the same value as .</returns>
        public static String Copy(this String str)
        {
            return String.Copy(str);
        }
    }


}