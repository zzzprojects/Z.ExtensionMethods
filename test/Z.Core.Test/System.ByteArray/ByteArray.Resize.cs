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
    public class System_ByteArray_Resize
    {
        [TestMethod]
        public void Resize()
        {
            // Type
            var @this = new Byte[1];
            @this[0] = 1;

            // Exemples
            @this = @this.Resize(4); // resize the array and keep value;

            // Unit Test
            Assert.AreEqual(1, @this[0]);
            Assert.AreEqual(4, @this.Length);
        }
    }
}