// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace Z.Reflection.Test
{
    [TestClass]
    public class System_Object_GetCustomAttribute
    {
        [TestMethod]
        public void GetCustomAttribute()
        {
            // Type
            var @this = new TestObject();

            // Exemples
            var result1 = @this.GetCustomAttribute<DescriptionAttribute>(true); // return "Test Description";
            object result2 = @this.GetCustomAttribute(typeof (DescriptionAttribute), true); // return "Test Description";

            // Unit Test
            Assert.AreEqual("Test Description", result1.Description);
            Assert.AreEqual("Test Description", ((DescriptionAttribute) result2).Description);
        }

        [Description("Test Description")]
        public class TestObject
        {
        }
    }
}