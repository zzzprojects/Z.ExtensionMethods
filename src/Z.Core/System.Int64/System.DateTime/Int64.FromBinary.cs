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