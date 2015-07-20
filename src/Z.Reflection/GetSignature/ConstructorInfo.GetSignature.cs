// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    public static string GetSignature(this ConstructorInfo @this)
    {
        // Example:  [Name] [<GenericArguments] ([Parameters])
        var sb = new StringBuilder();

        // Name
        sb.Append(@this.ReflectedType.IsGenericType ? @this.ReflectedType.Name.Substring(0, @this.ReflectedType.Name.IndexOf('`')) : @this.ReflectedType.Name);

        // Parameters
        ParameterInfo[] parameters = @this.GetParameters();
        sb.Append("(");
        sb.Append(string.Join(", ", parameters.Select(x => x.GetSignature())));
        sb.Append(")");

        return sb.ToString();
    }
}