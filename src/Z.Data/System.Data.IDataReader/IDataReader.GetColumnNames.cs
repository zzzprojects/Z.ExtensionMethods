// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Data;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Gets the column names in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An enumerator that allows foreach to be used to get the column names in this collection.</returns>
    public static IEnumerable<string> GetColumnNames(this IDataRecord @this)
    {
        return Enumerable.Range(0, @this.FieldCount)
            .Select(@this.GetName)
            .ToList();
    }
}