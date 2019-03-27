// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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