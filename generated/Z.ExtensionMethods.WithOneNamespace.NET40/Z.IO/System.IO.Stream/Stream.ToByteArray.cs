namespace Z.ExtensionMethods
{

using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A Stream extension method that converts the Stream to a byte array.
    /// </summary>
    /// <param name="this">The Stream to act on.</param>
    /// <returns>The Stream as a byte[].</returns>
    public static byte[] ToByteArray(this Stream @this)
    {
        using (var ms = new MemoryStream())
        {
            @this.CopyTo(ms);
            return ms.ToArray();
        }
    }
}

}