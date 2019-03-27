// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     A DbCommand extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A dynamic.</returns>
    public static dynamic ExecuteExpandoObject(this DbCommand @this)
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            reader.Read();
            return reader.ToExpandoObject();
        }
    }
}