using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Text.RegularExpressions;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that query if 'obj' is valid email.
        /// </summary>
        /// <param name="obj">The obj to act on.</param>
        /// <returns>true if valid email, false if not.</returns>
        public static bool IsValidEmail(this string obj)
        {
            return Regex.IsMatch(obj, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }


}