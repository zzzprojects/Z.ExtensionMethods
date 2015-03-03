namespace Z.ExtensionMethods
{

using System;
using System.Net;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts a long value from host byte order to network byte order.
        /// </summary>
        /// <param name="host">The number to convert, expressed in host byte order.</param>
        /// <returns>A long value, expressed in network byte order.</returns>
        public static Int64 HostToNetworkOrder(this Int64 host)
        {
            return IPAddress.HostToNetworkOrder(host);
        }
    }


}