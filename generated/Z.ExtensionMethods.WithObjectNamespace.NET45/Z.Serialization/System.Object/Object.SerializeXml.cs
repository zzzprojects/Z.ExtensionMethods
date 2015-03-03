namespace Z.ExtensionMethods.ObjectExtensions
{

using System.IO;
using System.Xml.Serialization;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that serialize a string to XML.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The string representation of the Xml Serialization.</returns>
    public static string SerializeXml(this object @this)
    {
        var xmlSerializer = new XmlSerializer(@this.GetType());

        using (var stringWriter = new StringWriter())
        {
            xmlSerializer.Serialize(stringWriter, @this);
            using (var streamReader = new StringReader(stringWriter.GetStringBuilder().ToString()))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}

}