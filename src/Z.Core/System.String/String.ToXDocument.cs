// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a XDocument.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an XDocument.</returns>
    public static XDocument ToXDocument(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        using (var ms = new MemoryStream(encoding.GetBytes(@this)))
        {
            return XDocument.Load(ms);
        }
    }
}