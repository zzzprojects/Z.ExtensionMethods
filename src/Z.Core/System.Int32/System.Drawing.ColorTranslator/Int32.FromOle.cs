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
    ///     Translates an OLE color value to a GDI+  structure.
    /// </summary>
    /// <param name="oleColor">The OLE color to translate.</param>
    /// <returns>The  structure that represents the translated OLE color.</returns>
    public static Color FromOle(this Int32 oleColor)
    {
        return ColorTranslator.FromOle(oleColor);
    }
#endif
}