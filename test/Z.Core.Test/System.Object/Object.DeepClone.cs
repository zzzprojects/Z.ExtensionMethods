// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_DeepClone
    {
        [TestMethod]
        public void DeepClone()
        {
            // Type
            var @this = new TestClass {Value = "Fizz"};

            // Exemples
            TestClass clone = @this.DeepClone(); // return a deep clone;

            // Unit Test
            Assert.AreEqual(@this.Value, clone.Value);
        }

        [Serializable]
        public class TestClass
        {
            public string Value;
        }
    }
}