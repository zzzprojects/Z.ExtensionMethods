using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 301 (Moved permanently.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusMovedPermanently(this HttpResponse @this)
    {
        @this.StatusCode = 301;
        @this.StatusDescription = "Moved permanently.";
    }
}

}