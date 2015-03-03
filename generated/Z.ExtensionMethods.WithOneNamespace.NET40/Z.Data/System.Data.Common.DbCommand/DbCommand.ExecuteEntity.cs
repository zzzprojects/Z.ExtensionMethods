namespace Z.ExtensionMethods
{

using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>
    ///     A DbCommand extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this DbCommand @this) where T : new()
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            reader.Read();
            return reader.ToEntity<T>();
        }
    }
}

}