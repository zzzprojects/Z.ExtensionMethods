using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.SerializationExtensions
{

using System.Web.Script.Serialization;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that deserialize a string binary as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desrialize binary as &lt;T&gt;</returns>
    public static T DeserializeJavaScript<T>(this string @this)
    {
        var serializer = new JavaScriptSerializer();
        return serializer.Deserialize<T>(@this);
    }
}

}