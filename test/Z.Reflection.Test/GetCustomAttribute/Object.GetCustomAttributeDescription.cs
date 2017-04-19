// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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