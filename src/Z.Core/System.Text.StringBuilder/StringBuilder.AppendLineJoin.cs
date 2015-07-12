// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


using System.Collections.Generic;
using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that appends a line join.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="separator">The separator.</param>
    /// <param name="values">The values.</param>
    public static StringBuilder AppendLineJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
    {
        @this.AppendLine(string.Join(separator, values));

        return @this;
    }

    /// <summary>A StringBuilder extension method that appends a line join.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="separator">The separator.</param>
    /// <param name="values">The values.</param>
    public static StringBuilder AppendLineJoin(this StringBuilder @this, string separator, params object[] values)
    {
        @this.AppendLine(string.Join(separator, values));

        return @this;
    }
}