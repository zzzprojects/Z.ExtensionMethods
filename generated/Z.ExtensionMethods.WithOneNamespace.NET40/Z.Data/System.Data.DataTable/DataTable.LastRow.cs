namespace Z.ExtensionMethods
{

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

}