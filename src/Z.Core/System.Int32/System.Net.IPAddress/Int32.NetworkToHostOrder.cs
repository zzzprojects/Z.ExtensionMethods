using System;
using System.Net;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts an integer value from network byte order to host byte order.
        /// </summary>
        /// <param name="network">The number to convert, expressed in network byte order.</param>
        /// <returns>An integer value, expressed in host byte order.</returns>
        public static Int32 NetworkToHostOrder(this Int32 network)
        {
            return IPAddress.NetworkToHostOrder(network);
        }
    }
