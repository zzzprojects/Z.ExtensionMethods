using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

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


}