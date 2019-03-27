// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified Windows file time to an equivalent local time.
    /// </summary>
    /// <param name="fileTime">A Windows file time expressed in ticks.</param>
    /// <returns>
    ///     An object that represents the local time equivalent of the date and time represented by the  parameter.
    /// </returns>
    public static DateTime FromFileTime(this Int64 fileTime)
    {
        return DateTime.FromFileTime(fileTime);
    }
}