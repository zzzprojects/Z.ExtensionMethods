// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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