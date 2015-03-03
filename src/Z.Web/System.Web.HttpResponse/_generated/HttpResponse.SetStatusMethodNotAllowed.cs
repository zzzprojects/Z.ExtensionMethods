using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 405 (Method Not Allowed.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusMethodNotAllowed(this HttpResponse @this)
    {
        @this.StatusCode = 405;
        @this.StatusDescription = "Method Not Allowed.";
    }
}