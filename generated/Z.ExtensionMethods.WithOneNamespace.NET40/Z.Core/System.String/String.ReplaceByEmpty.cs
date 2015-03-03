namespace Z.ExtensionMethods
{

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that replace all values specified by an empty string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="values">A variable-length parameters list containing values.</param>
        /// <returns>A string with all specified values replaced by an empty string.</returns>
        public static string ReplaceByEmpty(this string @this, params string[] values)
        {
            foreach (string value in values)
            {
                @this = @this.Replace(value, "");
            }

            return @this;
        }
    }


}