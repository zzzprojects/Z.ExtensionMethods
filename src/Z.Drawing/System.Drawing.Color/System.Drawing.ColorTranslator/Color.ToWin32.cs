// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
#if !NETSTANDARD
using System.Drawing;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Translates the specified  structure to a Windows color.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The Windows color value.</returns>
    public static Int32 ToWin32(this Color c)
    {
        return ColorTranslator.ToWin32(c);
    }
#endif
}