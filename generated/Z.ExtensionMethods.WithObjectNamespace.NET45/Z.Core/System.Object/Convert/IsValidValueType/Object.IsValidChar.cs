namespace Z.ExtensionMethods.ObjectExtensions
{

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid char.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid char, false if not.</returns>
        public static bool IsValidChar(this object @this)
        {
            char result;
            return char.TryParse(@this.ToString(), out result);
        }
    }


}