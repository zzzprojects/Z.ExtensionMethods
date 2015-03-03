namespace Z.ExtensionMethods
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 408 (Request timed out.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusRequestTimedOut(this HttpResponse @this)
    {
        @this.StatusCode = 408;
        @this.StatusDescription = "Request timed out.";
    }
}

}