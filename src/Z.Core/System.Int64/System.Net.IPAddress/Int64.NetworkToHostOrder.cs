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
    ///     Converts a long value from network byte order to host byte order.
    /// </summary>
    /// <param name="network">The number to convert, expressed in network byte order.</param>
    /// <returns>A long value, expressed in host byte order.</returns>
    public static Int64 NetworkToHostOrder(this Int64 network)
    {
        return IPAddress.NetworkToHostOrder(network);
    }
}