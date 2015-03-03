namespace Z.ExtensionMethods
{

using System.Web;

public static partial class Extensions
{
    /// <summary>
    ///     A HttpResponse extension method that redirects.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="urlFormat">The URL format.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    public static void Redirect(this HttpResponse @this, string urlFormat, params object[] values)
    {
        string url = string.Format(urlFormat, values);
        @this.Redirect(url, true);
    }
}

}