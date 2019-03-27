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
    public class System_Object_GetPropertyValue
    {
        [TestMethod]
        public void GetPropertyValue()
        {
            // Type
            var @this = new TestClass {PublicProperty = 1};
            TestClass.InternaStaticProperty = 2;

            // Exemples
            object result1 = @this.GetPropertyValue("PublicProperty"); // return 1;
            object result2 = @this.GetPropertyValue("InternaStaticProperty"); // return 2;

            // Unit Test
            Assert.AreEqual(1, result1);
            Assert.AreEqual(2, result2);
        }

        public class TestClass
        {
            internal static int InternaStaticProperty { get; set; }
            public int PublicProperty { get; set; }
        }
    }
}