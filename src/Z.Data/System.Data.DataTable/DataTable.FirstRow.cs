// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     A DataTable extension method that return the first row.
    /// </summary>
    /// <param name="this">The table to act on.</param>
    /// <returns>The first row of the table.</returns>
    public static DataRow FirstRow(this DataTable @this)
    {
        return @this.Rows[0];
    }
}