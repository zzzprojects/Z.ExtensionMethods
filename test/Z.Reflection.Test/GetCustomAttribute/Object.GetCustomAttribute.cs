// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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