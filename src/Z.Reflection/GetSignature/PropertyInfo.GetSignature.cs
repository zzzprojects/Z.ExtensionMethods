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
    /// <summary>A PropertyInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this PropertyInfo @this)
    {
        // Example: [Name | Indexer[Type]]

        var indexerParameter = @this.GetIndexParameters();
        if (indexerParameter.Length == 0)
        {
            // Name
            return @this.Name;
        }
        var sb = new StringBuilder();

        // Indexer
        sb.Append(@this.Name);
        sb.Append("[");
        sb.Append(string.Join(", ", indexerParameter.Select(x => x.ParameterType.GetShortSignature())));
        sb.Append("]");

        return sb.ToString();
    }
}