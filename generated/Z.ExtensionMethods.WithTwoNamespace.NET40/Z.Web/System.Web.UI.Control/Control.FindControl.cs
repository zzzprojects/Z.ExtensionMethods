using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Web.UI;

public static partial class Extensions
{
    /// <summary>
    ///     Searches the current naming container for a server control with the specified id parameter.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="id">The identifier for the control to be found.</param>
    /// <returns>The specified control, or a null reference if the specified control does not exist.</returns>
    public static T FindControl<T>(this Control @this, string id) where T : class
    {
        return (@this.FindControl(id) as T);
    }
}

}