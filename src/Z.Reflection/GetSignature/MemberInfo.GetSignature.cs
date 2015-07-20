// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A MemberInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this MemberInfo @this)
    {
        switch (@this.MemberType)
        {
            case MemberTypes.Field:
                return ((FieldInfo) @this).GetSignature();
            case MemberTypes.Property:
                return ((PropertyInfo) @this).GetSignature();
            case MemberTypes.Constructor:
                return ((ConstructorInfo) @this).GetSignature();
            case MemberTypes.Method:
                return ((MethodInfo) @this).GetSignature();
            case MemberTypes.TypeInfo:
                return ((Type) @this).GetSignature();
            case MemberTypes.NestedType:
                return ((Type) @this).GetSignature();
            case MemberTypes.Event:
                return ((EventInfo) @this).GetSignature();
            default:
                return null;
        }
    }
}