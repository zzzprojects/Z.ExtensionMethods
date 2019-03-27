// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to a byte array.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a byte[].</returns>
    public static byte[] ToByteArray(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        return encoding.GetBytes(@this);
    }
}