using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that sets the response to status code 203 (Nonauthoritative information.).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void SetStatusNonauthoritativeInformation(this HttpResponse @this)
    {
        @this.StatusCode = 203;
        @this.StatusDescription = "Nonauthoritative information.";
    }
}

}