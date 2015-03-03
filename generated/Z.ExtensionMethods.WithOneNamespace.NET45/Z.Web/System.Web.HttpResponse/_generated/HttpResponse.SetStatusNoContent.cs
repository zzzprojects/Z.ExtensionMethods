namespace Z.ExtensionMethods
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 204 (No content.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusNoContent(this HttpResponse @this)
    {
        @this.StatusCode = 204;
        @this.StatusDescription = "No content.";
    }
}

}