// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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