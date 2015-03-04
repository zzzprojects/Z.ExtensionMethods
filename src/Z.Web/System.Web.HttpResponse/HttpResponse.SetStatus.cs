// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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