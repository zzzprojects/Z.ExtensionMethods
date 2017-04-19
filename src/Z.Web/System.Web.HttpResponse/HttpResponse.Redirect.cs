// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that redirects.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="urlFormat">The URL format.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    public static void Redirect(this HttpResponse @this, string urlFormat, params object[] values)
    {
        string url = string.Format(urlFormat, values);
        @this.Redirect(url, true);
    }
}