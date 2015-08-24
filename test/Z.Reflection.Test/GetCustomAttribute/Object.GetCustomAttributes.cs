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
    public class System_Object_GetCustomAttributes_CustomAttribute : Attribute
    {
        public string Text;

        public System_Object_GetCustomAttributes_CustomAttribute(string text)
        {
            Text = text;
        }
    }

    [System_Object_GetCustomAttributes_Custom("Test Class")]
    public class System_Object_GetCustomAttributes_TestClass
    {
    }

    public enum System_Object_GetCustomAttributes_TestEnum
    {
        [System_Object_GetCustomAttributes_Custom("Test Enum")] Test
    }

    [TestClass]
    public class System_Object_GetCustomAttributes
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttribute()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttributes_TestClass();
            var @thisEnum = System_Object_GetCustomAttributes_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttributes<System_Object_GetCustomAttributes_CustomAttribute>();
            var result2 = @thisClass.GetCustomAttributes<System_Object_GetCustomAttributes_CustomAttribute>(false);
            var result3 = @thisClass.GetType().GetCustomAttributes<System_Object_GetCustomAttributes_CustomAttribute>();
            var result4 = @thisClass.GetType().GetCustomAttributes<System_Object_GetCustomAttributes_CustomAttribute>(false);
            var result5 = @thisClass.GetCustomAttributes();
            var result6 = @thisClass.GetCustomAttributes(false);
            var result7 = @thisEnum.GetCustomAttributes<System_Object_GetCustomAttributes_CustomAttribute>();
            var result8 = @thisEnum.GetCustomAttributes<System_Object_GetCustomAttributes_CustomAttribute>(false);
            var result9 = @thisEnum.GetCustomAttributes();
            var result10 = @thisEnum.GetCustomAttributes(false);

            // Unit Test
            Assert.AreEqual("Test Class", result1[0].Text);
            Assert.AreEqual("Test Class", result2[0].Text);
            Assert.AreEqual("Test Class", result3[0].Text);
            Assert.AreEqual("Test Class", result4[0].Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributes_CustomAttribute) result5[0]).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributes_CustomAttribute) result6[0]).Text);
            Assert.AreEqual("Test Enum", result7[0].Text);
            Assert.AreEqual("Test Enum", result8[0].Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributes_CustomAttribute) result9[0]).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributes_CustomAttribute) result10[0]).Text);
        }
    }
}