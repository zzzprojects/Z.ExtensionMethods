namespace Z.ExtensionMethods
{

using System.Web.Script.Serialization;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that serialize java script.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string SerializeJavaScript<T>(this T @this)
    {
        var serializer = new JavaScriptSerializer();
        return serializer.Serialize(@this);
    }
}

}