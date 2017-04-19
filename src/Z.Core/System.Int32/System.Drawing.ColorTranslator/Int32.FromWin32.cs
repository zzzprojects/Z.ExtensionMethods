// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     Translates a Windows color value to a GDI+  structure.
    /// </summary>
    /// <param name="win32Color">The Windows color to translate.</param>
    /// <returns>The  structure that represents the translated Windows color.</returns>
    public static Color FromWin32(this Int32 win32Color)
    {
        return ColorTranslator.FromWin32(win32Color);
    }
}