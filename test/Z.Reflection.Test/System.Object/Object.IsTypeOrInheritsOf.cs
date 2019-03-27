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
    public class System_Object_IsTypeOrInheritsOf
    {
        [TestMethod]
        public void IsTypeOrInheritsOf()
        {
            // Type
            var @this = new C();

            // Exemples
            bool result1 = @this.IsTypeOrInheritsOf(typeof (C)); // return true;
            bool result2 = @this.IsTypeOrInheritsOf(typeof (B)); // return true;
            bool result3 = @this.IsTypeOrInheritsOf(typeof (A)); // return true;
            bool result4 = @this.IsTypeOrInheritsOf(typeof (string)); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.IsFalse(result4);
        }

        public class A
        {
        }

        public class B : A
        {
        }

        public class C : B
        {
        }
    }
}