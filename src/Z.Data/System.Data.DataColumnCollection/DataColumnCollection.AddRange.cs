// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     A DataColumnCollection extension method that adds a range to 'columns'.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="columns">A variable-length parameters list containing columns.</param>
    public static void AddRange(this DataColumnCollection @this, params string[] columns)
    {
        foreach (string column in columns)
        {
            @this.Add(column);
        }
    }
}