using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.WebExtensions
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 202 (Accepted.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusAccepted(this HttpResponse @this)
    {
        @this.StatusCode = 202;
        @this.StatusDescription = "Accepted.";
    }
}

}