// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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