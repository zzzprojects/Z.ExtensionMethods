// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A MethodInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this MethodInfo @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
        var sb = new StringBuilder();

        // Visibility
        if (@this.IsPublic)
        {
            sb.Append("public ");
        }
        else if (@this.IsFamily)
        {
            sb.Append("protected ");
        }
        else if (@this.IsAssembly)
        {
            sb.Append("internal ");
        }
        else if (@this.IsPrivate)
        {
            sb.Append("private ");
        }
        else
        {
            sb.Append("protected internal ");
        }

        // Modifier
        if (@this.IsAbstract)
        {
            sb.Append("abstract ");
        }
        else if (@this.GetBaseDefinition().DeclaringType != @this.DeclaringType)
        {
            sb.Append("override ");
        }
        else if (@this.IsVirtual)
        {
            sb.Append("virtual ");
        }
        else if (@this.IsStatic)
        {
            sb.Append("static ");
        }

        // Type
        sb.Append(@this.ReturnType.GetShortDeclaraction());
        sb.Append(" ");

        // Name
        sb.Append(@this.Name);

        if (@this.IsGenericMethod)
        {
            sb.Append("<");

            Type[] arguments = @this.GetGenericArguments();

            sb.Append(string.Join(", ", arguments.Select(x => x.GetShortDeclaraction())));

            sb.Append(">");
        }

        // Parameters
        ParameterInfo[] parameters = @this.GetParameters();
        sb.Append("(");
        sb.Append(string.Join(", ", parameters.Select(x => x.GetDeclaraction())));
        sb.Append(")");

        return sb.ToString();
    }
}