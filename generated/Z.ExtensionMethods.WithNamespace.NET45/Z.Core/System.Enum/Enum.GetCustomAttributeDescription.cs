using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;
using System.ComponentModel;
using System.Linq;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that gets description attribute.
        /// </summary>
        /// <param name="value">The value to act on.</param>
        /// <returns>The description attribute.</returns>
        public static string GetCustomAttributeDescription(this Enum value)
        {
            var attr = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return attr.Description;
        }
    }


}