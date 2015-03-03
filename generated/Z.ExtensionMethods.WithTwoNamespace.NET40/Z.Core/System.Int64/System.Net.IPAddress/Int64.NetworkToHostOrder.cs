using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

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


}