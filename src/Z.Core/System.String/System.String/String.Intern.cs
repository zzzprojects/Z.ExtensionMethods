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
    ///     Retrieves the system&#39;s reference to the specified .
    /// </summary>
    /// <param name="str">A string to search for in the intern pool.</param>
    /// <returns>
    ///     The system&#39;s reference to , if it is interned; otherwise, a new reference to a string with the value of .
    /// </returns>
    public static String Intern(this String str)
    {
        return String.Intern(str);
    }
}