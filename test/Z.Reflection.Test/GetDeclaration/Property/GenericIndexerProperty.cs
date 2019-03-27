// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Property_GetDeclaration_GenericIndexerProperty
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            PropertyInfo @this = typeof (PropertyModel<>).GetProperties().First(x => x.Name == "Item" && x.GetIndexParameters().Length == 2);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public T this[T param1, int param2] { get; }", result);
        }
    }
}