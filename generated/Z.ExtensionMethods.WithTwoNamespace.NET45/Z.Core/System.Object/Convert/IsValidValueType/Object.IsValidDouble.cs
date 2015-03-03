namespace Z.ExtensionMethods.ObjectExtensions
{

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that query if '@this' is valid double.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid double, false if not.</returns>
        public static bool IsValidDouble(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            double result;
            return double.TryParse(@this.ToString(), out result);
        }
    }


}