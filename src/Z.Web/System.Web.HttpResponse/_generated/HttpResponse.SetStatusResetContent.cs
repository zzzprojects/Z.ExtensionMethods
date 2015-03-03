using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 205 (Reset content.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusResetContent(this HttpResponse @this)
    {
        @this.StatusCode = 205;
        @this.StatusDescription = "Reset content.";
    }
}