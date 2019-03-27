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
    ///     Returns the natural (base e) logarithm of a specified number.
    /// </summary>
    /// <param name="d">The number whose logarithm is to be found.</param>
    /// <returns>
    ///     One of the values in the following table.  parameterReturn value Positive The natural logarithm of ; that is,
    ///     ln , or log eZero Negative Equal to Equal to.
    /// </returns>
    public static Double Log(this Double d)
    {
        return Math.Log(d);
    }

    /// <summary>
    ///     Returns the logarithm of a specified number in a specified base.
    /// </summary>
    /// <param name="d">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>
    ///     One of the values in the following table. (+Infinity denotes , -Infinity denotes , and NaN denotes .)Return
    ///     value&gt; 0(0 &lt;&lt; 1) -or-(&gt; 1)lognewBase(a)&lt; 0(any value)NaN(any value)&lt; 0NaN != 1 = 0NaN != 1
    ///     = +InfinityNaN = NaN(any value)NaN(any value) = NaNNaN(any value) = 1NaN = 00 &lt;&lt; 1 +Infinity = 0&gt; 1-
    ///     Infinity =  +Infinity0 &lt;&lt; 1-Infinity =  +Infinity&gt; 1+Infinity = 1 = 00 = 1 = +Infinity0.
    /// </returns>
    /// ###
    /// <param name="a">The number whose logarithm is to be found.</param>
    public static Double Log(this Double d, Double newBase)
    {
        return Math.Log(d, newBase);
    }
}