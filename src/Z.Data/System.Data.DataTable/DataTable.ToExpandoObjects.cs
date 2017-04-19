// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.Data;
using System.Dynamic;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates to expando objects in this collection.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an IEnumerable&lt;dynamic&gt;</returns>
    /// ###
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public static IEnumerable<dynamic> ToExpandoObjects(this DataTable @this)
    {
        var list = new List<dynamic>();

        foreach (DataRow dr in @this.Rows)
        {
            dynamic entity = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>) entity;

            foreach (DataColumn column in @this.Columns)
            {
                expandoDict.Add(column.ColumnName, dr[column]);
            }


            list.Add(entity);
        }

        return list;
    }
}