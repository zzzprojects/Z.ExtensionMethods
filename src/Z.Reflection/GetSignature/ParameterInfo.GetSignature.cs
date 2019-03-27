// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

public static partial class Extensions
{
    /// <summary>A ParameterInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this ParameterInfo @this)
    {
        var sb = new StringBuilder();

        @this.GetSignature(sb);
        return sb.ToString();
    }

    internal static void GetSignature(this ParameterInfo @this, StringBuilder sb)
    {
        // retval attribute

        string typeName;
        Type elementType = @this.ParameterType.GetElementType();

        if (elementType != null)
        {
            typeName = @this.ParameterType.Name.Replace(elementType.Name, elementType.GetShortSignature());
        }
        else
        {
            typeName = @this.ParameterType.GetShortSignature();
        }

        if (@this.IsOut)
        {
            if (typeName.Contains("&"))
            {
                typeName = typeName.Replace("&", "");
                sb.Append("out ");
            }
        }
        else if (@this.ParameterType.IsByRef)
        {
            typeName = typeName.Replace("&", "");
            sb.Append("ref ");
        }
        sb.Append(typeName);
    }
}