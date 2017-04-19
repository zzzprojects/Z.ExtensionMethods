// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Xml.Linq.Test
{
    [TestClass]
    public class System_Xml_Linq_XElement_RemoveAllNamespaces
    {
        [TestMethod]
        public void RemoveAllNamespaces()
        {
            // Variables
            XDocument xDocument = null;
            using (var ms = new MemoryStream(Encoding.Default.GetBytes("<z:test xmlns:z=\"http://www.w3.org/TR/html4/\"><z:test2 /></z:test>")))
            {
                xDocument = XDocument.Load(ms);
            }

            // Type
            XElement @this = xDocument.Root;

            int result1 = @this.Elements("test2").ToList().Count; // return 0;
            // Exemples
            @this = @this.RemoveAllNamespaces(); // remove the "z" namespace
            int result2 = @this.Elements("test2").ToList().Count; // return 1;

            // Unit Test
            Assert.AreEqual(0, result1);
            Assert.AreEqual(1, result2);
        }
    }
}