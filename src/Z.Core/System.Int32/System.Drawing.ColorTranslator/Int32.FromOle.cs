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
    ///     Translates an OLE color value to a GDI+  structure.
    /// </summary>
    /// <param name="oleColor">The OLE color to translate.</param>
    /// <returns>The  structure that represents the translated OLE color.</returns>
    public static Color FromOle(this Int32 oleColor)
    {
        return ColorTranslator.FromOle(oleColor);
    }
}