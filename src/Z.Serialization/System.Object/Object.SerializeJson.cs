// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that serialize an object to Json.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The Json string.</returns>
    public static string SerializeJson<T>(this T @this)
    {
        var serializer = new DataContractJsonSerializer(typeof (T));

        using (var memoryStream = new MemoryStream())
        {
            serializer.WriteObject(memoryStream, @this);
            return Encoding.Default.GetString(memoryStream.ToArray());
        }
    }

    /// <summary>
    ///     A T extension method that serialize an object to Json.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>The Json string.</returns>
    public static string SerializeJson<T>(this T @this, Encoding encoding)
    {
        var serializer = new DataContractJsonSerializer(typeof (T));

        using (var memoryStream = new MemoryStream())
        {
            serializer.WriteObject(memoryStream, @this);
            return encoding.GetString(memoryStream.ToArray());
        }
    }
}