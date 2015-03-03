using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 304 (Not modified.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusNotModified(this HttpResponse @this)
    {
        @this.StatusCode = 304;
        @this.StatusDescription = "Not modified.";
    }
}