// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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