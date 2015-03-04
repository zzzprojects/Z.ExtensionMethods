// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsLike
    {
        [TestMethod]
        public void IsLike()
        {
            // Type
            string @this = "FizzBuzz3";

            // Examples
            bool value1 = @this.IsLike("Fizz*"); // return true;
            bool value2 = @this.IsLike("*zzB*"); // return true;
            bool value3 = @this.IsLike("*Buzz#"); // return true;
            bool value4 = @this.IsLike("*zz?u*"); // return true;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsTrue(value4);
        }
    }
}