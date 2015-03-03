namespace Z.ExtensionMethods
{

using System.Globalization;
using System.Text;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that removes the diacritics character from the strings.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The string without diacritics character.</returns>
        public static string RemoveDiacritics(this string @this)
        {
            string normalizedString = @this.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (char t in normalizedString)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(t);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(t);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }


}