// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A T extension method that gets property or field.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <returns>The property or field.</returns>
    public static MemberInfo GetPropertyOrField<T>(this T @this, string name)
    {
        PropertyInfo property = @this.GetProperty(name);
        if (property != null)
        {
            return property;
        }

        FieldInfo field = @this.GetField(name);
        if (field != null)
        {
            return field;
        }

        return null;
    }
}