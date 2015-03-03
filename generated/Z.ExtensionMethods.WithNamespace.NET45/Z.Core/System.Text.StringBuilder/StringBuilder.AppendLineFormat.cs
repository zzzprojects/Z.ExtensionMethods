using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System.Collections.Generic;
using System.Text;

public static partial class Extensions
    {
        /// <summary>
        ///     A StringBuilder extension method that appends a line format.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="format">Describes the format to use.</param>
        /// <param name="args">A variable-length parameters list containing arguments.</param>
        public static void AppendLineFormat(this StringBuilder @this, string format, params object[] args)
        {
            @this.AppendLine(string.Format(format, args));
        }

        /// <summary>
        ///     A StringBuilder extension method that appends a line format.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="format">Describes the format to use.</param>
        /// <param name="args">A variable-length parameters list containing arguments.</param>
        public static void AppendLineFormat(this StringBuilder @this, string format, List<IEnumerable<object>> args)
        {
            @this.AppendLine(string.Format(format, args));
        }
    }


}