// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;
using System.Net;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A WebRequest extension method that gets the WebRequest response and read the response stream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The response stream as a string, from the current position to the end.</returns>
    public static string ReadToEndAndDispose(this WebResponse @this)
    {
        using (WebResponse response = @this)
        {
            using (Stream stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}