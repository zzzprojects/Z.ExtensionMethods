namespace Z.ExtensionMethods
{

using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether any custom attributes are applied to an assembly. Parameters specify the assembly, and the
    ///     type of the custom attribute to search for.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
    public static Boolean IsDefined(this Assembly element, Type attributeType)
    {
        return Attribute.IsDefined(element, attributeType);
    }

    /// <summary>
    ///     Determines whether any custom attributes are applied to an assembly. Parameters specify the assembly, the
    ///     type of the custom attribute to search for, and an ignored search option.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
    /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
    public static Boolean IsDefined(this Assembly element, Type attributeType, Boolean inherit)
    {
        return Attribute.IsDefined(element, attributeType, inherit);
    }
}

}