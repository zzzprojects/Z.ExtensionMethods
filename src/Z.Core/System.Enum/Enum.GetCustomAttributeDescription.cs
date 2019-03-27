// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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