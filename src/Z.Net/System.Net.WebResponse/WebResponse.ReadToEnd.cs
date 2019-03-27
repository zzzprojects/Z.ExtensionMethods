// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     A WebResponse extension method that reads the response stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The response stream as a string, from the current position to the end.</returns>
    public static string ReadToEnd(this WebResponse @this)
    {
        using (Stream stream = @this.GetResponseStream())
        {
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}