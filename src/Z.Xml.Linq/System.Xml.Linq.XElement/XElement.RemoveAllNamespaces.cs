// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Linq;
using System.Xml.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An XElement extension method that removes all namespaces described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An XElement.</returns>
    public static XElement RemoveAllNamespaces(this XElement @this)
    {
        return new XElement(@this.Name.LocalName,
            (from n in @this.Nodes()
                select ((n is XElement) ? RemoveAllNamespaces(n as XElement) : n)),
            (@this.HasAttributes) ? (from a in @this.Attributes() select a) : null);
    }
}