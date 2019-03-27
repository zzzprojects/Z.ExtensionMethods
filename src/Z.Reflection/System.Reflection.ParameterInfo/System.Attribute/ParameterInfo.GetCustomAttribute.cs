// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, and the
    ///     type of the custom attribute to search for.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <returns>
    ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
    ///     attribute.
    /// </returns>
    public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType)
    {
        return Attribute.GetCustomAttribute(element, attributeType);
    }

    /// <summary>
    ///     Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, the type
    ///     of the custom attribute to search for, and whether to search ancestors of the method parameter.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
    /// <returns>
    ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
    ///     attribute.
    /// </returns>
    public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, Boolean inherit)
    {
        return Attribute.GetCustomAttribute(element, attributeType, inherit);
    }
}