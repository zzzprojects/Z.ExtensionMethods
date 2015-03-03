namespace Z.ExtensionMethods
{

using System.IO;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that reads the file to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this FileInfo @this)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }

    /// <summary>
    ///     A FileInfo extension method that reads the file to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="position">The position.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this FileInfo @this, long position)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            stream.Position = position;

            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }

    /// <summary>
    ///     A FileInfo extension method that reads the file to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this FileInfo @this, Encoding encoding)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (var reader = new StreamReader(stream, encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }

    /// <summary>
    ///     A FileInfo extension method that reads the file to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="encoding">The encoding.</param>
    /// <param name="position">The position.</param>
    /// <returns>
    ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
    ///     end of the stream, returns an empty string ("").
    /// </returns>
    public static string ReadToEnd(this FileInfo @this, Encoding encoding, long position)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            stream.Position = position;

            using (var reader = new StreamReader(stream, encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }
}

}