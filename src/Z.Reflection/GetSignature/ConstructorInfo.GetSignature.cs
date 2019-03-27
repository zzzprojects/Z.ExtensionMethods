// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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