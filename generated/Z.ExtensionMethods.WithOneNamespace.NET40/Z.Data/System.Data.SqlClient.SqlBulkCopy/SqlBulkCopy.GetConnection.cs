namespace Z.ExtensionMethods
{

using System;
using System.Data.SqlClient;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A SqlBulkCopy extension method that gets a connection.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The connection.</returns>
    public static SqlConnection GetConnection(this SqlBulkCopy @this)
    {
        Type type = @this.GetType();
        FieldInfo field = type.GetField("_connection", BindingFlags.NonPublic | BindingFlags.Instance);
// ReSharper disable PossibleNullReferenceException
        return field.GetValue(@this) as SqlConnection;
// ReSharper restore PossibleNullReferenceException
    }
}

}