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
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    public static void SetStatus(this HttpResponse @this, int code)
    {
        @this.StatusCode = code;
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="endResponse">true to end response.</param>
    public static void SetStatus(this HttpResponse @this, int code, bool endResponse)
    {
        @this.StatusCode = code;

        if (endResponse)
        {
            @this.End();
        }
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
    public static void SetStatus(this HttpResponse @this, int code, string description)
    {
        @this.StatusCode = code;
        @this.StatusDescription = description;
    }

    /// <summary>
    ///     A HttpResponse extension method that sets the status.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
    /// <param name="endResponse">true to end response.</param>
    public static void SetStatus(this HttpResponse @this, int code, string description, bool endResponse)
    {
        @this.StatusCode = code;
        @this.StatusDescription = description;

        if (endResponse)
        {
            @this.End();
        }
    }
}