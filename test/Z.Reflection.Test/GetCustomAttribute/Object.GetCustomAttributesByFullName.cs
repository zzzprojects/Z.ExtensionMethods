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
    public class System_Object_GetCustomAttributesByFullName_CustomAttribute : Attribute
    {
        public string Text;

        public System_Object_GetCustomAttributesByFullName_CustomAttribute(string text)
        {
            Text = text;
        }
    }

    [System_Object_GetCustomAttributesByFullName_Custom("Test Class")]
    public class System_Object_GetCustomAttributesByFullName_TestClass
    {
    }

    public enum System_Object_GetCustomAttributesByFullName_TestEnum
    {
        [System_Object_GetCustomAttributesByFullName_Custom("Test Enum")] Test
    }

    [TestClass]
    public class System_Object_GetCustomAttributesByFullName
    {
        /// <summary>
        ///     System.String GetCustomAttributeDescription(System.Object)
        /// </summary>
        [TestMethod]
        public void GetCustomAttributesByFullName()
        {
            // Type
            var @thisClass = new System_Object_GetCustomAttributesByFullName_TestClass();
            var @thisEnum = System_Object_GetCustomAttributesByFullName_TestEnum.Test;

            // Exemples
            var result1 = @thisClass.GetCustomAttributesByFullName("Z.Reflection.Test.System_Object_GetCustomAttributesByFullName_CustomAttribute");
            var result2 = @thisClass.GetCustomAttributesByFullName("Z.Reflection.Test.System_Object_GetCustomAttributesByFullName_CustomAttribute", false);
            var result3 = @thisClass.GetType().GetCustomAttributesByFullName("Z.Reflection.Test.System_Object_GetCustomAttributesByFullName_CustomAttribute");
            var result4 = @thisClass.GetType().GetCustomAttributesByFullName("Z.Reflection.Test.System_Object_GetCustomAttributesByFullName_CustomAttribute", false);
            var result5 = @thisEnum.GetCustomAttributesByFullName("Z.Reflection.Test.System_Object_GetCustomAttributesByFullName_CustomAttribute");
            var result6 = @thisEnum.GetCustomAttributesByFullName("Z.Reflection.Test.System_Object_GetCustomAttributesByFullName_CustomAttribute", false);

            // Unit Test
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByFullName_CustomAttribute) result1[0]).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByFullName_CustomAttribute) result2[0]).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByFullName_CustomAttribute) result3[0]).Text);
            Assert.AreEqual("Test Class", ((System_Object_GetCustomAttributesByFullName_CustomAttribute) result4[0]).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributesByFullName_CustomAttribute) result5[0]).Text);
            Assert.AreEqual("Test Enum", ((System_Object_GetCustomAttributesByFullName_CustomAttribute) result6[0]).Text);
        }
    }
}