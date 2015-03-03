namespace Z.ExtensionMethods
{

using System.Xml;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that converts the @this to an XmlDocument.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an XmlDocument.</returns>
        public static XmlDocument ToXmlDocument(this string @this)
        {
            var doc = new XmlDocument();
            doc.LoadXml(@this);
            return doc;
        }
    }


}