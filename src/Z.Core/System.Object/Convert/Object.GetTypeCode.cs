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
    ///     Returns the  for the specified object.
    /// </summary>
    /// <param name="value">An object that implements the  interface.</param>
    /// <returns>The  for , or  if  is null.</returns>
    public static TypeCode GetTypeCode(this Object value)
    {
        return Convert.GetTypeCode(value);
    }
}