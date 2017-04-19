// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Nl2Br
    {
        [TestMethod]
        public void Nl2Br()
        {
            // Type
            string @this = "Fizz" + Environment.NewLine + "Buzz";

            // Exemples
            string result = @this.Nl2Br(); // return "Fizz<br />Buzz";

            // Unit Test
            Assert.AreEqual("Fizz<br />Buzz", result);
        }
    }
}