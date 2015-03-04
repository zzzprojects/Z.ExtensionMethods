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
    ///     Translates an OLE color value to a GDI+  structure.
    /// </summary>
    /// <param name="oleColor">The OLE color to translate.</param>
    /// <returns>The  structure that represents the translated OLE color.</returns>
    public static Color FromOle(this Int32 oleColor)
    {
        return ColorTranslator.FromOle(oleColor);
    }
}