// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Security;

public static partial class Extensions
{
    /// <summary>
    ///     A String extension method that converts the @this to a secure string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a SecureString.</returns>
    public static SecureString ToSecureString(this string @this)
    {
        var secureString = new SecureString();
        foreach (Char c in @this)
            secureString.AppendChar(c);

        return secureString;
    }
}