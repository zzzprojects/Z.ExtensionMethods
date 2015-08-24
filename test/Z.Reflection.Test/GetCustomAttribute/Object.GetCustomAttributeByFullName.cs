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
    public class System_Object_GetCustomAttributeByFullName_CustomAttribute : Attribute
    {
        public string Text;

        public System_Object_GetCustomAttributeByFullName_CustomAttribute(string text)
        {
            Text = text;
        }
    }

    [System_Object_GetCustomAttributeByFullName_Custom("Test Class")]
    public class System_Object_GetCustomAttributeByFullName_TestClass
    {
    }

    public enum System_Object_GetCustomAttributeByFullName_TestEnum
    {
        [System_Object_GetCustomAttributeByFullName_Custom("Test Enum")] Test
    }

    [TestClass]
    public class System_Object_GetCustomAttributeByFullName
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttributeByFullName()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttributeByFullName_TestClass();
            var @thisEnum = System_Object_GetCustomAttributeByFullName_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttributeByFullName("Z.Reflection.Test.System_Object_GetCustomAttributeByFullName_CustomAttribute");
            var result2 = @thisClass.GetCustomAttributeByFullName("Z.Reflection.Test.System_Object_GetCustomAttributeByFullName_CustomAttribute", false);
            var result3 = @thisClass.GetType().GetCustomAttributeByFullName("Z.Reflection.Test.System_Object_GetCustomAttributeByFullName_CustomAttribute");
            var result4 = @thisClass.GetType().GetCustomAttributeByFullName("Z.Reflection.Test.System_Object_GetCustomAttributeByFullName_CustomAttribute", false);
            var result5 = @thisEnum.GetCustomAttributeByFullName("Z.Reflection.Test.System_Object_GetCustomAttributeByFullName_CustomAttribute");
            var result6 = @thisEnum.GetCustomAttributeByFullName("Z.Reflection.Test.System_Object_GetCustomAttributeByFullName_CustomAttribute", false);

            // Unit Test
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByFullName_CustomAttribute) result1).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByFullName_CustomAttribute) result2).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByFullName_CustomAttribute) result3).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributeByFullName_CustomAttribute) result4).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributeByFullName_CustomAttribute) result5).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributeByFullName_CustomAttribute) result6).Text);
        }
    }
}