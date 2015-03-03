using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.WebExtensions
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 501 (Header values specify a
    ///     configuration that is not implemented.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusInvalidHeaderValueConfiguration(this HttpResponse @this)
    {
        @this.StatusCode = 501;
        @this.StatusDescription = "Header values specify a configuration that is not implemented.";
    }
}

}