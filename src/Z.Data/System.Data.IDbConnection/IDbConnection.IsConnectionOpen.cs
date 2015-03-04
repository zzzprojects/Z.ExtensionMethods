// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Data;
using System.Data.Common;

public static partial class Extensions
{
    /// <summary>A DbConnection extension method that queries if a connection is open.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if a connection is open, false if not.</returns>
    public static bool IsConnectionOpen(this DbConnection @this)
    {
        return @this.State == ConnectionState.Open;
    }
}