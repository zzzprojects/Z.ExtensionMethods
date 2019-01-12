// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
// 

using System;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>Gets the total number of lines in a file. </summary>
    /// <param name="this">The file to perform the count on.</param>
    /// <returns>The total number of lines in a file. </returns>
    public static int CountLines(this FileInfo @this)
    {
        return File.ReadAllLines(@this.FullName).Length;
    }

    /// <summary>Gets the total number of lines in a file that satisfy the condition in the predicate function.</summary>
    /// <param name="this">The file to perform the count on.</param>
    /// <param name="predicate">A function to test each line for a condition.</param>
    /// <returns>The total number of lines in a file that satisfy the condition in the predicate function.</returns>
    public static int CountLines(this FileInfo @this, Func<string, bool> predicate)
    {
        return File.ReadAllLines(@this.FullName).Count(predicate);
    }
}