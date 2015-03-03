using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Data;
using System.Data.SQLite;

public static partial class Extensions
{
    /// <summary>
    ///     Executes the query, and returns the first result set as DataTable.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DataTable that is equivalent to the first result set.</returns>
    public static DataTable ExecuteDataTable(this SQLiteCommand @this)
    {
        var dt = new DataTable();
        using (var dataAdapter = new SQLiteDataAdapter(@this))
        {
            dataAdapter.Fill(dt);
        }

        return dt;
    }
}

}