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
    ///     A byte[] extension method that converts the @this to a memory stream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a MemoryStream.</returns>
    public static MemoryStream ToMemoryStream(this byte[] @this)
    {
        return new MemoryStream(@this);
    }
}