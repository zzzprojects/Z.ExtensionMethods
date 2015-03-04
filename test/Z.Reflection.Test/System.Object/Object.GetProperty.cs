// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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