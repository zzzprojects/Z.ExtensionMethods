using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 307 (Temporary redirect.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusTemporaryRedirect(this HttpResponse @this)
    {
        @this.StatusCode = 307;
        @this.StatusDescription = "Temporary redirect.";
    }
}