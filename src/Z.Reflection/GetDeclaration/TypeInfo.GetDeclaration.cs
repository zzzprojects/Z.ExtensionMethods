// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A Type extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this Type @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
        var sb = new StringBuilder();

        // Variable
        bool hasInheritedClass = false;

        // Visibility
        sb.Append(@this.IsPublic ? "public " : "internal ");

        // Modifier
        if (!@this.IsInterface && @this.IsAbstract)
        {
            sb.Append(@this.IsSealed ? "static " : "abstract ");
        }

        // Type
        sb.Append(@this.IsInterface ? "interface " : "class ");

        // Name
        sb.Append(@this.IsGenericType ? @this.Name.Substring(0, @this.Name.IndexOf('`')) : @this.Name);

        // GenericArguments
        if (@this.IsGenericType)
        {
            Type[] arguments = @this.GetGenericArguments();
            sb.Append("<");
            sb.Append(string.Join(", ", arguments.Select(x =>
            {
                Type[] constraints = x.GetGenericParameterConstraints();

                foreach (Type constraint in constraints)
                {
                    GenericParameterAttributes gpa = constraint.GenericParameterAttributes;
                    GenericParameterAttributes variance = gpa & GenericParameterAttributes.VarianceMask;

                    if (variance != GenericParameterAttributes.None)
                    {
                        sb.Append((variance & GenericParameterAttributes.Covariant) != 0 ? "in " : "out ");
                    }
                }

                return x.GetShortDeclaraction();
            })));
            sb.Append(">");
        }

        // Inherited Class
        if (@this.BaseType != null && @this.BaseType != typeof (object))
        {
            hasInheritedClass = true;

            sb.Append(" : ");
            sb.Append(@this.BaseType.GetShortDeclaraction());
        }

        // Inherited Interface
        Type[] interfaces = @this.GetInterfaces();
        if (interfaces.Length > 0)
        {
            sb.Append(hasInheritedClass ? ", " : " : ");
            sb.Append(string.Join(", ", interfaces.Select(x => x.Name)));
        }

        return sb.ToString();
    }
}