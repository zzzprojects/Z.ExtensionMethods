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
}