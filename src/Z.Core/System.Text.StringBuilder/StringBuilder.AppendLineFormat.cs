// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Collections.Generic;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A StringBuilder extension method that appends a line format.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="format">Describes the format to use.</param>
    /// <param name="args">A variable-length parameters list containing arguments.</param>
    public static StringBuilder AppendLineFormat(this StringBuilder @this, string format, params object[] args)
    {
        @this.AppendLine(string.Format(format, args));

        return @this;
    }

    /// <summary>
    ///     A StringBuilder extension method that appends a line format.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="format">Describes the format to use.</param>
    /// <param name="args">A variable-length parameters list containing arguments.</param>
    public static StringBuilder AppendLineFormat(this StringBuilder @this, string format, List<IEnumerable<object>> args)
    {
        @this.AppendLine(string.Format(format, args));

        return @this;
    }
}