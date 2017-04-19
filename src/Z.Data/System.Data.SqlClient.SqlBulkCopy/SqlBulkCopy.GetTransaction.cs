// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Data.SqlClient;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A SqlBulkCopy extension method that gets a transaction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The transaction.</returns>
    public static SqlTransaction GetTransaction(this SqlBulkCopy @this)
    {
        Type type = @this.GetType();
        FieldInfo field = type.GetField("_externalTransaction", BindingFlags.NonPublic | BindingFlags.Instance);
// ReSharper disable PossibleNullReferenceException
        return field.GetValue(@this) as SqlTransaction;
// ReSharper restore PossibleNullReferenceException
    }
}