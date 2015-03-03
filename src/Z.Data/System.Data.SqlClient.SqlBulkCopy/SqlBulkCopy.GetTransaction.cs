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