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
    public class Method_GetSignature_AbstractMethod
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            MethodInfo @this = typeof (AbstractMethodModel).GetMethod("AbstractMethod", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("AbstractMethod()", result);
        }
    }
}