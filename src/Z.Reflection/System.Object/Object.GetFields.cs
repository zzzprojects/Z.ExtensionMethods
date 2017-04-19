// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Reflection;

public static partial class Extensions
{
    /// <summary>An object extension method that gets the fields.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An array of field information.</returns>
    public static FieldInfo[] GetFields(this object @this)
    {
        return @this.GetType().GetFields();
    }

    /// <summary>An object extension method that gets the fields.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="bindingAttr">The binding attribute.</param>
    /// <returns>An array of field information.</returns>
    public static FieldInfo[] GetFields(this object @this, BindingFlags bindingAttr)
    {
        return @this.GetType().GetFields(bindingAttr);
    }
}