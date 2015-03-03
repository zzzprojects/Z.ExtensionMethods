using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.WebExtensions
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that reloads the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void Reload(this HttpResponse @this)
    {
        @this.Redirect(HttpContext.Current.Request.Url.ToString(), true);
    }
}

}