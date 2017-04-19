// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Data;

public static partial class Extensions
{
    /// <summary>
    ///     An IDataReader extension method that query if '@this' is database null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The name.</param>
    /// <returns>true if database null, false if not.</returns>
    public static bool IsDBNull(this IDataReader @this, string name)
    {
        return @this.IsDBNull(@this.GetOrdinal(name));
    }
}