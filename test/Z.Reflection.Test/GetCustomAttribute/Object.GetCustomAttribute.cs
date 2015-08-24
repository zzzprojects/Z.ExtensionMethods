// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [AttributeUsage(AttributeTargets.All)]
    public class System_Object_GetCustomAttribute_CustomAttribute : Attribute
    {
        public string Text;

        public System_Object_GetCustomAttribute_CustomAttribute(string text)
        {
            Text = text;
        }
    }

    [System_Object_GetCustomAttribute_Custom("Test Class")]
    public class System_Object_GetCustomAttribute_TestClass
    {
    }

    public enum System_Object_GetCustomAttribute_TestEnum
    {
        [System_Object_GetCustomAttribute_Custom("Test Enum")]
        Test
    }

    [TestClass]
    public class System_Object_GetCustomAttribute
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttribute()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttribute_TestClass();
            var @thisEnum = System_Object_GetCustomAttribute_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttribute<System_Object_GetCustomAttribute_CustomAttribute>();
            var result2 = @thisClass.GetCustomAttribute<System_Object_GetCustomAttribute_CustomAttribute>(false);
            var result3 = @thisClass.GetType().GetCustomAttribute<System_Object_GetCustomAttribute_CustomAttribute>();
            var result4 = @thisClass.GetType().GetCustomAttribute<System_Object_GetCustomAttribute_CustomAttribute>(false);
            var result5 = @thisClass.GetCustomAttribute(typeof(System_Object_GetCustomAttribute_CustomAttribute));
            var result6 = @thisClass.GetCustomAttribute(typeof(System_Object_GetCustomAttribute_CustomAttribute), false);
            var result7 = @thisClass.GetType().GetCustomAttribute(typeof(System_Object_GetCustomAttribute_CustomAttribute));
            var result8 = @thisClass.GetType().GetCustomAttribute(typeof(System_Object_GetCustomAttribute_CustomAttribute), false);
            var result9 = @thisEnum.GetCustomAttribute<System_Object_GetCustomAttribute_CustomAttribute>();
            var result10 = @thisEnum.GetCustomAttribute<System_Object_GetCustomAttribute_CustomAttribute>(false);
            var result11 = @thisEnum.GetCustomAttribute(typeof(System_Object_GetCustomAttribute_CustomAttribute));
            var result12 = @thisEnum.GetCustomAttribute(typeof(System_Object_GetCustomAttribute_CustomAttribute), false);

            // Unit Test
            Assert.AreEqual("Test Class", result1.Text);
            Assert.AreEqual("Test Class", result2.Text);
            Assert.AreEqual("Test Class", result3.Text);
            Assert.AreEqual("Test Class", result4.Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttribute_CustomAttribute)result5).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttribute_CustomAttribute)result6).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttribute_CustomAttribute)result7).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttribute_CustomAttribute)result8).Text);
            Assert.AreEqual("Test Enum", result9.Text);
            Assert.AreEqual("Test Enum", result10.Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttribute_CustomAttribute)result11).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttribute_CustomAttribute)result12).Text);
        }
    }
}