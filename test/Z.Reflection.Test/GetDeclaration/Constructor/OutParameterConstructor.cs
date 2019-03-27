// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Constructor_GetDeclaration_OutParameterConstructor
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            ConstructorInfo @this = typeof(OutParameterConstructorModel).GetConstructors()[0];

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public OutParameterConstructorModel(out int i)", result);
        }
    }
}