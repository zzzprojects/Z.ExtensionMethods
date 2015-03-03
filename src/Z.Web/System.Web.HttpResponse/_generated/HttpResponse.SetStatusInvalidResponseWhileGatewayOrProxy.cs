using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 502 (Web server received an invalid
    ///     response while acting as a gateway or proxy. ).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusInvalidResponseWhileGatewayOrProxy(this HttpResponse @this)
    {
        @this.StatusCode = 502;
        @this.StatusDescription = "Web server received an invalid response while acting as a gateway or proxy. ";
    }
}