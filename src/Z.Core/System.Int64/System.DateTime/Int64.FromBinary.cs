// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Deserializes a 64-bit binary value and recreates an original serialized  object.
    /// </summary>
    /// <param name="dateData">
    ///     A 64-bit signed integer that encodes the  property in a 2-bit field and the  property in
    ///     a 62-bit field.
    /// </param>
    /// <returns>An object that is equivalent to the  object that was serialized by the  method.</returns>
    public static DateTime FromBinary(this Int64 dateData)
    {
        return DateTime.FromBinary(dateData);
    }
}