// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A MethodInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this MethodInfo @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
        var sb = new StringBuilder();

        // Name
        sb.Append(@this.Name);

        if (@this.IsGenericMethod)
        {
            sb.Append("<");

            Type[] arguments = @this.GetGenericArguments();

            sb.Append(string.Join(", ", arguments.Select(x => x.GetShortSignature())));

            sb.Append(">");
        }

        // Parameters
        ParameterInfo[] parameters = @this.GetParameters();
        sb.Append("(");
        sb.Append(string.Join(", ", parameters.Select(x => x.GetSignature())));
        sb.Append(")");

        return sb.ToString();
    }
}