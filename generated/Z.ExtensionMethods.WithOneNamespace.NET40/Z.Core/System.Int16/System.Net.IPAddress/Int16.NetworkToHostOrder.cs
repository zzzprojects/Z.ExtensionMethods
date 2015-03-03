namespace Z.ExtensionMethods
{

using System;
using System.Net;

public static partial class Extensions
    {
        /// <summary>
        ///     Converts a short value from network byte order to host byte order.
        /// </summary>
        /// <param name="network">The number to convert, expressed in network byte order.</param>
        /// <returns>A short value, expressed in host byte order.</returns>
        public static Int16 NetworkToHostOrder(this Int16 network)
        {
            return IPAddress.NetworkToHostOrder(network);
        }
    }


}