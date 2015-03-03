using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 406 (Client browser does not accept the
    ///     MIME type of the requested page.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusClientBrowserDoesNotAcceptMimeType(this HttpResponse @this)
    {
        @this.StatusCode = 406;
        @this.StatusDescription = "Client browser does not accept the MIME type of the requested page.";
    }
}