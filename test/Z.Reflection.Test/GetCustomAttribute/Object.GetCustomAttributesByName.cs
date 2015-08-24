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
    public class System_Object_GetCustomAttributesByName_CustomAttribute : Attribute
    {
        public string Text;

        public System_Object_GetCustomAttributesByName_CustomAttribute(string text)
        {
            Text = text;
        }
    }

    [System_Object_GetCustomAttributesByName_Custom("Test Class")]
    public class System_Object_GetCustomAttributesByName_TestClass
    {
    }

    public enum System_Object_GetCustomAttributesByName_TestEnum
    {
        [System_Object_GetCustomAttributesByName_Custom("Test Enum")] Test
    }

    [TestClass]
    public class System_Object_GetCustomAttributesByName
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttributesByName()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttributesByName_TestClass();
            var @thisEnum = System_Object_GetCustomAttributesByName_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttributesByName("System_Object_GetCustomAttributesByName_CustomAttribute");
            var result2 = @thisClass.GetCustomAttributesByName("System_Object_GetCustomAttributesByName_CustomAttribute", false);
            var result3 = @thisClass.GetType().GetCustomAttributesByName("System_Object_GetCustomAttributesByName_CustomAttribute");
            var result4 = @thisClass.GetType().GetCustomAttributesByName("System_Object_GetCustomAttributesByName_CustomAttribute", false);
            var result5 = @thisEnum.GetCustomAttributesByName("System_Object_GetCustomAttributesByName_CustomAttribute");
            var result6 = @thisEnum.GetCustomAttributesByName("System_Object_GetCustomAttributesByName_CustomAttribute", false);

            // Unit Test
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByName_CustomAttribute) result1[0]).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByName_CustomAttribute) result2[0]).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByName_CustomAttribute) result3[0]).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByName_CustomAttribute) result4[0]).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributesByName_CustomAttribute) result5[0]).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributesByName_CustomAttribute) result6[0]).Text);
        }
    }
}