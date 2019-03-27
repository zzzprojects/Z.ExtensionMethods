// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Data;

public static partial class Extensions
{
    /// <summary>A DataTable extension method that last row.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DataRow.</returns>
    public static DataRow LastRow(this DataTable @this)
    {
        return @this.Rows[@this.Rows.Count - 1];
    }
}