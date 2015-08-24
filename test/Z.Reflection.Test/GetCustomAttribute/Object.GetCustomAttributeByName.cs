// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class System_Object_GetCustomAttributeByName_CustomAttribute : Attribute
    {
        public string Text;

        public System_Object_GetCustomAttributeByName_CustomAttribute(string text)
        {
            Text = text;
        }
    }

    [System_Object_GetCustomAttributeByName_Custom("Test Class")]
    public class System_Object_GetCustomAttributeByName_TestClass
    {
    }

    public enum System_Object_GetCustomAttributeByName_TestEnum
    {
        [System_Object_GetCustomAttributeByName_Custom("Test Enum")] Test
    }

    [TestClass]
    public class System_Object_GetCustomAttributeByName
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttributeByName()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttributeByName_TestClass();
            var @thisEnum = System_Object_GetCustomAttributeByName_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute");
            var result2 = @thisClass.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute", false);
            var result3 = @thisClass.GetType().GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute");
            var result4 = @thisClass.GetType().GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute", false);
            var result5 = @thisEnum.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute");
            var result6 = @thisEnum.GetCustomAttributeByName("System_Object_GetCustomAttributeByName_CustomAttribute", false);

            // Unit Test
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result1).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result2).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result3).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByName_CustomAttribute) result4).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributeByName_CustomAttribute) result5).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributeByName_CustomAttribute) result6).Text);
        }
    }
}