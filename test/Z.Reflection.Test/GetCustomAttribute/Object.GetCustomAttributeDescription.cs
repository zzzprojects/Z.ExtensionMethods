// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [System.ComponentModel.Description("Test Description")]
    public class System_Object_GetCustomAttributeDescription_TestClass
    {
    }

    public enum System_Object_GetCustomAttributeDescription_TestEnum
    {
        [System.ComponentModel.Description("Test Description")] Test
    }

    [TestClass]
    public class System_Object_GetCustomAttributeDescription
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttributeDescription()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttributeDescription_TestClass();
            var @thisEnum = System_Object_GetCustomAttributeDescription_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttributeDescription();
            var result2 = @thisClass.GetCustomAttributeDescription(false);
            var result3 = @thisClass.GetType().GetCustomAttributeDescription();
            var result4 = @thisClass.GetType().GetCustomAttributeDescription(false);
            var result5 = @thisEnum.GetCustomAttributeDescription();
            var result6 = @thisEnum.GetCustomAttributeDescription(false);

            // Unit Test
            Assert.AreEqual("Test Description", result1);
            Assert.AreEqual("Test Description", result2);
            Assert.AreEqual("Test Description", result3);
            Assert.AreEqual("Test Description", result4);
            Assert.AreEqual("Test Description", result5);
            Assert.AreEqual("Test Description", result6);
        }
    }
}