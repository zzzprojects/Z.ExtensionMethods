using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     Translates the specified  structure to an OLE color.
    /// </summary>
    /// <param name="c">The  structure to translate.</param>
    /// <returns>The OLE color value.</returns>
    public static Int32 ToOle(this Color c)
    {
        return ColorTranslator.ToOle(c);
    }
}

}