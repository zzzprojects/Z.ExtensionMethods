// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     A WebRequest extension method that gets the WebRequest response or the WebException response.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The WebRequest response or WebException response.</returns>
    public static WebResponse GetResponseSafe(this WebRequest @this)
    {
        try
        {
            return @this.GetResponse();
        }
        catch (WebException e)
        {
            return e.Response;
        }
    }
}