namespace Z.ExtensionMethods
{

using System;
using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     Translates the specified  structure to a Windows color.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The Windows color value.</returns>
    public static Int32 ToWin32(this Color c)
    {
        return ColorTranslator.ToWin32(c);
    }
}

}