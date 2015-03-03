using System.Linq;
using System.Xml.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     An XElement extension method that removes all namespaces described by @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An XElement.</returns>
    public static XElement RemoveAllNamespaces(this XElement @this)
    {
        return new XElement(@this.Name.LocalName,
            (from n in @this.Nodes()
                select ((n is XElement) ? RemoveAllNamespaces(n as XElement) : n)),
            (@this.HasAttributes) ? (from a in @this.Attributes() select a) : null);
    }
}