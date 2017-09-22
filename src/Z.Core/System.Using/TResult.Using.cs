// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     Using statement extension to skip small using blocks.
    /// </summary>
    /// <param name="factory">The factory function to create disposable object to act on.</param>
    /// <param name="action">The function to use disposable object and return result</param>
    /// <returns>TResult from specified action function</returns>
    public static TResult Using<TDisposable, TResult>(Func<TDisposable> factory, Func<TDisposable, TResult> action)
        where TDisposable : IDisposable
    {
        using (var disposable = factory()) 
        {
            return action(disposable);
        }
    }
}