// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
#if !NETSTANDARD
using System.Drawing;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Creates a  structure from a 32-bit ARGB value.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <returns>The  structure that this method creates.</returns>
    public static Color FromArgb(this Int32 argb)
    {
        return Color.FromArgb(argb);
    }

    /// <summary>
    ///     Creates a  structure from the four ARGB component (alpha, red, green, and blue) values. Although this method
    ///     allows a 32-bit value to be passed for each component, the value of each component is limited to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="red">The red component. Valid values are 0 through 255.</param>
    /// <param name="green">The green component. Valid values are 0 through 255.</param>
    /// <param name="blue">The blue component. Valid values are 0 through 255.</param>
    /// <returns>The  that this method creates.</returns>
    /// ###
    /// <param name="alpha">The alpha component. Valid values are 0 through 255.</param>
    public static Color FromArgb(this Int32 argb, Int32 red, Int32 green, Int32 blue)
    {
        return Color.FromArgb(argb, red, green, blue);
    }

    /// <summary>
    ///     Creates a  structure from the specified  structure, but with the new specified alpha value. Although this
    ///     method allows a 32-bit value to be passed for the alpha value, the value is limited to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="baseColor">The  from which to create the new .</param>
    /// <returns>The  that this method creates.</returns>
    /// ###
    /// <param name="alpha">The alpha value for the new . Valid values are 0 through 255.</param>
    public static Color FromArgb(this Int32 argb, Color baseColor)
    {
        return Color.FromArgb(argb, baseColor);
    }

    /// <summary>
    ///     Creates a  structure from the specified 8-bit color values (red, green, and blue). The alpha value is
    ///     implicitly 255 (fully opaque). Although this method allows a 32-bit value to be passed for each color
    ///     component, the value of each component is limited to 8 bits.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <param name="green">The green component value for the new . Valid values are 0 through 255.</param>
    /// <param name="blue">The blue component value for the new . Valid values are 0 through 255.</param>
    /// <returns>The  that this method creates.</returns>
    /// ###
    /// <param name="red">The red component value for the new . Valid values are 0 through 255.</param>
    public static Color FromArgb(this Int32 argb, Int32 green, Int32 blue)
    {
        return Color.FromArgb(argb, green, blue);
    }
#endif
}