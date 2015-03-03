using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that reverses the given string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The string reversed.</returns>
        public static string Reverse(this string @this)
        {
            if (@this.Length <= 1)
            {
                return @this;
            }

            char[] chars = @this.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
