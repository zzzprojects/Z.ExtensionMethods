// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Char_To
    {
        [TestMethod]
        public void To()
        {
            // Type
            char @this = 'A';

            // Examples
            List<char> list = @this.To('C').ToList(); // return new [] {'a', 'b', 'c'};

            // Unit Test
            Assert.AreEqual(3, list.Count);
        }
    }
}