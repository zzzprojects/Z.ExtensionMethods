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
    ///     Translates the specified  structure to an HTML string color representation.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The string that represents the HTML color.</returns>
    public static String ToHtml(this Color c)
    {
        return ColorTranslator.ToHtml(c);
    }
}