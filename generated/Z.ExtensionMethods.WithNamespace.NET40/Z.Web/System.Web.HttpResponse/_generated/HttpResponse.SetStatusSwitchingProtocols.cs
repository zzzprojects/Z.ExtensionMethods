using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.WebExtensions
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 101 (Switching protocols.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusSwitchingProtocols(this HttpResponse @this)
    {
        @this.StatusCode = 101;
        @this.StatusDescription = "Switching protocols.";
    }
}

}