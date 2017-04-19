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