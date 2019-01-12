// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.IO;

public static partial class Extensions
{
    /// <summary>
    /// Skips the specified number of lines in a stream reader based on its current position.
    /// </summary>
    /// <param name="this">The stream reader.</param>
    /// <param name="skipCount">The number of lines to skip.</param>
    public static void SkipLines(this StreamReader @this, int skipCount)
    {
        for (var i = 0; i < skipCount && !@this.EndOfStream; i++)
        {
            @this.ReadLine();
        }
    }
}