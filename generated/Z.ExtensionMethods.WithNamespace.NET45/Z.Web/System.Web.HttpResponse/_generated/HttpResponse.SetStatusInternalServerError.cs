using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.WebExtensions
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 500 (Internal server error. ).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusInternalServerError(this HttpResponse @this)
    {
        @this.StatusCode = 500;
        @this.StatusDescription = "Internal server error. ";
    }
}

}