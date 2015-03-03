using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 302 (Object moved.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusObjectMoved(this HttpResponse @this)
    {
        @this.StatusCode = 302;
        @this.StatusDescription = "Object moved.";
    }
}

}