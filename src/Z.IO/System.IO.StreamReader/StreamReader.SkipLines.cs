// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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