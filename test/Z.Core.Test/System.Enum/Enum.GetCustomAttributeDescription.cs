// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Enum_GetCustomAttributeDescription
    {
        public enum TestEnum
        {
            [System.ComponentModel.Description("Test Description")] Test
        }

        [TestMethod]
        public void GetCustomAttributeDescription()
        {
            // Type
            var @this = TestEnum.Test;

            // Exemples
            string result = @this.GetCustomAttributeDescription(); // return "Test Description";

            // Unit Test
            Assert.AreEqual("Test Description", result);
        }
    }
}