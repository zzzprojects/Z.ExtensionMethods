namespace Z.ExtensionMethods
{

using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

public static partial class Extensions
    {
        /// <summary>
        ///     A string extension method that converts the @this to a XDocument.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an XDocument.</returns>
        public static XDocument ToXDocument(this string @this)
        {
            Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
            using (var ms = new MemoryStream(encoding.GetBytes(@this)))
            {
                return XDocument.Load(ms);
            }
        }
    }


}