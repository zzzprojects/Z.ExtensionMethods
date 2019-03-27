// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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