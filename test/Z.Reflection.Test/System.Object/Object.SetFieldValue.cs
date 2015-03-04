// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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