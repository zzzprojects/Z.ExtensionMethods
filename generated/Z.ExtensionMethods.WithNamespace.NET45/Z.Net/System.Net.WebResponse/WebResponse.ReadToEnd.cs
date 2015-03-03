using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.NetExtensions
{

using System.IO;
using System.Net;

public static partial class Extensions
{
    /// <summary>
    ///     A WebResponse extension method that reads the response stream to the end.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The response stream as a string, from the current position to the end.</returns>
    public static string ReadToEnd(this WebResponse @this)
    {
        using (Stream stream = @this.GetResponseStream())
        {
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}

}