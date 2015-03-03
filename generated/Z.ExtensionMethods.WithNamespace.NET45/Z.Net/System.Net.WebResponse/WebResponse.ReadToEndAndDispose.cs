using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.NetExtensions
{

using System.IO;
using System.Net;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A WebRequest extension method that gets the WebRequest response and read the response stream.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The response stream as a string, from the current position to the end.</returns>
    public static string ReadToEndAndDispose(this WebResponse @this)
    {
        using (WebResponse response = @this)
        {
            using (Stream stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}

}