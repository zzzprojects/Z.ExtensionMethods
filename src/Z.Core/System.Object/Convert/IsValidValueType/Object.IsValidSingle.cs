// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid float.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid float, false if not.</returns>
    public static bool IsValidSingle(this object @this)
    {
        if (@this == null)
        {
            return true;
        }

        float result;
        return float.TryParse(@this.ToString(), out result);
    }
}