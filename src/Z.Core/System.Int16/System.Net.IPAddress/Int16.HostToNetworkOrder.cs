// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a short value from host byte order to network byte order.
    /// </summary>
    /// <param name="host">The number to convert, expressed in host byte order.</param>
    /// <returns>A short value, expressed in network byte order.</returns>
    public static Int16 HostToNetworkOrder(this Int16 host)
    {
        return IPAddress.HostToNetworkOrder(host);
    }
}