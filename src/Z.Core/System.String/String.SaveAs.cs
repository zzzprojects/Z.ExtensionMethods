// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that save the string into a file.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fileName">Filename of the file.</param>
    /// <param name="append">(Optional) if the text should be appended to file file if it's exists.</param>
    public static void SaveAs(this string @this, string fileName, bool append = false)
    {
        using (TextWriter tw = new StreamWriter(fileName, append))
        {
            tw.Write(@this);
        }
    }

    /// <summary>
    ///     A string extension method that save the string into a file.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="file">The FileInfo.</param>
    /// <param name="append">(Optional) if the text should be appended to file file if it's exists.</param>
    public static void SaveAs(this string @this, FileInfo file, bool append = false)
    {
        using (TextWriter tw = new StreamWriter(file.FullName, append))
        {
            tw.Write(@this);
        }
    }
}