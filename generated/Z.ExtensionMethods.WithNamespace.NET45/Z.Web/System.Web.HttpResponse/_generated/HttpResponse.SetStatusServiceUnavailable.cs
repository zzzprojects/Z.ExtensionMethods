using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.WebExtensions
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 503 (Service unavailable. ).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusServiceUnavailable(this HttpResponse @this)
    {
        @this.StatusCode = 503;
        @this.StatusDescription = "Service unavailable. ";
    }
}

}