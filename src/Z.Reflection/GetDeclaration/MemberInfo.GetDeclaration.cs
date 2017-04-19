// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A MemberInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this MemberInfo @this)
    {
        switch (@this.MemberType)
        {
            case MemberTypes.Field:
                return ((FieldInfo) @this).GetDeclaraction();
            case MemberTypes.Property:
                return ((PropertyInfo) @this).GetDeclaraction();
            case MemberTypes.Constructor:
                return ((ConstructorInfo) @this).GetDeclaraction();
            case MemberTypes.Method:
                return ((MethodInfo) @this).GetDeclaraction();
            case MemberTypes.TypeInfo:
                return ((Type) @this).GetDeclaraction();
            case MemberTypes.NestedType:
                return ((Type) @this).GetDeclaraction();
            case MemberTypes.Event:
                return ((EventInfo) @this).GetDeclaraction();
            default:
                return null;
        }
    }
}