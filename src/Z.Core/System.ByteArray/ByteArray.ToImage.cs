// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
#if !NETSTANDARD
using System.Drawing;
using System.IO;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A byte[] extension method that converts the @this to an image.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an Image.</returns>
    public static Image ToImage(this byte[] @this)
    {
        using (var ms = new MemoryStream(@this))
        {
            return Image.FromStream(ms);
        }
    }
#endif
}