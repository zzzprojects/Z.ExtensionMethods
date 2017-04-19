// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that query if '@this' contains column.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnIndex">Zero-based index of the column.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsColumn(this IDataReader @this, int columnIndex)
    {
        try
        {
            // Check if FieldCount is implemented first
            return @this.FieldCount > columnIndex;
        }
        catch (Exception)
        {
            try
            {
                return @this[columnIndex] != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    /// <summary>
    ///     An IDataReader extension method that query if '@this' contains column.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columnName">Name of the column.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsColumn(this IDataReader @this, string columnName)
    {
        try
        {
            // Check if GetOrdinal is implemented first
            return @this.GetOrdinal(columnName) != -1;
        }
        catch (Exception)
        {
            try
            {
                return @this[columnName] != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}