// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Linq;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <returns>The custom attribute by full name.</returns>
    public static object GetCustomAttributeByFullName(this object @this, string fullName)
    {
        var type = @this.GetType();

        var attributes = type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray() :
            type.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();

        if (attributes.Length == 0)
        {
            return null;
        }

        if (attributes.Length == 1)
        {
            return attributes[0];
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }

    /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The custom attribute by full name.</returns>
    public static object GetCustomAttributeByFullName(this object @this, string fullName, bool inherit)
    {
        var type = @this.GetType();

        var attributes = type.IsEnum ?
            type.GetField(@this.ToString()).GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray() :
            type.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();

        if (attributes.Length == 0)
        {
            return null;
        }

        if (attributes.Length == 1)
        {
            return attributes[0];
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }

    /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <returns>The custom attribute by full name.</returns>
    public static object GetCustomAttributeByFullName(this MemberInfo @this, string fullName)
    {
        var attributes = @this.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();

        if (attributes.Length == 0)
        {
            return null;
        }

        if (attributes.Length == 1)
        {
            return attributes[0];
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }

    /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
    /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullName">Name of the full.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>The custom attribute by full name.</returns>
    public static object GetCustomAttributeByFullName(this MemberInfo @this, string fullName, bool inherit)
    {
        var attributes = @this.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();

        if (attributes.Length == 0)
        {
            return null;
        }

        if (attributes.Length == 1)
        {
            return attributes[0];
        }

        throw new Exception(string.Format("Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.", attributes.Length));
    }
}