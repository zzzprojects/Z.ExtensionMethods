using System.Data;
using System.Data.SqlServerCe;

public static partial class Extensions
{
    /// <summary>
    ///     Executes the query, and returns the first result set as DataTable.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DataTable that is equivalent to the first result set.</returns>
    public static DataTable ExecuteDataTable(this SqlCeCommand @this)
    {
        var dt = new DataTable();
        using (var dataAdapter = new SqlCeDataAdapter(@this))
        {
            dataAdapter.Fill(dt);
        }

        return dt;
    }
}