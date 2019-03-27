// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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