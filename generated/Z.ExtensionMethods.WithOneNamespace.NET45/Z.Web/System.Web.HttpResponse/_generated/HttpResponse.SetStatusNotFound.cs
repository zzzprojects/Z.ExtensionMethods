namespace Z.ExtensionMethods
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 404 (Not found. ).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusNotFound(this HttpResponse @this)
    {
        @this.StatusCode = 404;
        @this.StatusDescription = "Not found. ";
    }
}

}