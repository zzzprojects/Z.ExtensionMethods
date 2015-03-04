// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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