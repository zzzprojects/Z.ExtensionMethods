// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class System_Object_SetFieldValue
    {
        [TestMethod]
        public void SetFieldValue()
        {
            // Type
            var @this = new TestClass();

            // Exemples
            @this.SetFieldValue("PublicField", 1);
            @this.SetFieldValue("InternaStaticlField", 2);

            // Unit Test
            Assert.AreEqual(1, @this.PublicField);
            Assert.AreEqual(2, TestClass.InternaStaticlField);
        }

        public class TestClass
        {
            internal static int InternaStaticlField = 2;
            public int PublicField = 1;
        }
    }
}