// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that deserialize a string binary as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desrialize binary as &lt;T&gt;</returns>
    public static T DeserializeBinary<T>(this string @this)
    {
        using (var stream = new MemoryStream(Encoding.Default.GetBytes(@this)))
        {
            var binaryRead = new BinaryFormatter();
            return (T) binaryRead.Deserialize(stream);
        }
    }

    /// <summary>
    ///     A string extension method that deserialize a string binary as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>The desrialize binary as &lt;T&gt;</returns>
    public static T DeserializeBinary<T>(this string @this, Encoding encoding)
    {
        using (var stream = new MemoryStream(encoding.GetBytes(@this)))
        {
            var binaryRead = new BinaryFormatter();
            return (T) binaryRead.Deserialize(stream);
        }
    }
}