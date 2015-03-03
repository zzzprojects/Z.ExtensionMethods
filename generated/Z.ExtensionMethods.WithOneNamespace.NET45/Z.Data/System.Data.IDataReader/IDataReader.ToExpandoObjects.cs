namespace Z.ExtensionMethods
{

using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates to expando objects in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an IEnumerable&lt;dynamic&gt;</returns>
    public static IEnumerable<dynamic> ToExpandoObjects(this IDataReader @this)
    {
        Dictionary<int, KeyValuePair<int, string>> columnNames = Enumerable.Range(0, @this.FieldCount)
            .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
            .ToDictionary(pair => pair.Key);

        var list = new List<dynamic>();

        while (@this.Read())
        {
            dynamic entity = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>) entity;

            Enumerable.Range(0, @this.FieldCount)
                .ToList()
                .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

            list.Add(entity);
        }

        return list;
    }
}

}