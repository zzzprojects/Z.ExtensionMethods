// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Enumerates from @this to toCharacter.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="toCharacter">to character.</param>
    /// <returns>An enumerator that allows foreach to be used to process @this to toCharacter.</returns>
    public static IEnumerable<char> To(this char @this, char toCharacter)
    {
        bool reverseRequired = (@this > toCharacter);

        char first = reverseRequired ? toCharacter : @this;
        char last = reverseRequired ? @this : toCharacter;

        IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char) charCode);

        if (reverseRequired)
        {
            result = result.Reverse();
        }


        return result;
    }
}