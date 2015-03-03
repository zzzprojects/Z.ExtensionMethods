using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Creates a proxy for the well-known object indicated by the specified type and URL.
        /// </summary>
        /// <param name="type">The type of the well-known object to which you want to connect.</param>
        /// <param name="url">The URL of the well-known object.</param>
        /// <returns>A proxy that points to an endpoint served by the requested well-known object.</returns>
        public static System.Object GetObject(this Type type, String url)
        {
            return Activator.GetObject(type, url);
        }

        /// <summary>
        ///     Creates a proxy for the well-known object indicated by the specified type, URL, and channel data.
        /// </summary>
        /// <param name="type">The type of the well-known object to which you want to connect.</param>
        /// <param name="url">The URL of the well-known object.</param>
        /// <param name="state">Channel-specific data or null.</param>
        /// <returns>A proxy that points to an endpoint served by the requested well-known object.</returns>
        public static System.Object GetObject(this Type type, String url, System.Object state)
        {
            return Activator.GetObject(type, url, state);
        }
    }
