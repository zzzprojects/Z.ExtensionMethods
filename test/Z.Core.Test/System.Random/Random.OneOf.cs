// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Random_OneOf
    {
        [TestMethod]
        public void OneOf()
        {
            // Type
            var @this = new Random();

            // Examples
            int value1 = @this.OneOf(1, 2, 3, 4); // return one of this value at random.
            string value2 = @this.OneOf("a", "b", "c", "d"); // return one of this value at random.
            object value3 = @this.OneOf(1, "a", DateTime.Now, new object()); // return one of this value at random.
        }
    }
}