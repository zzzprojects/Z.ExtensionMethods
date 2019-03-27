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
    public class System_Object_SetPropertyValue
    {
        [TestMethod]
        public void SetPropertyValue()
        {
            // Type
            var @this = new TestClass();

            // Exemples
            @this.SetPropertyValue("PublicProperty", 1);
            @this.SetPropertyValue("InternaStaticlProperty", 2);

            // Unit Test
            Assert.AreEqual(1, @this.PublicProperty);
            Assert.AreEqual(2, TestClass.InternaStaticlProperty);
        }

        public class TestClass
        {
            internal static int InternaStaticlProperty { get; set; }
            public int PublicProperty { get; set; }
        }
    }
}