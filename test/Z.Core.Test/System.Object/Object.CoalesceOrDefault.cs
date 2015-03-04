// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_CoalesceOrDefault
    {
        [TestMethod]
        public void CoalesceOrDefault()
        {
            // Varable
            object nullObject = null;

            // Type
            object @thisNull = null;
            object @thisNotNull = "Fizz";

            // Exemples
            object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, "Buzz"); // return "Buzz";
            object result2 = @thisNull.CoalesceOrDefault(() => "Buzz", null, null); // return "Buzz";
            object result3 = @thisNull.CoalesceOrDefault(x => "Buzz", null, null); // return "Buzz";
            object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, "Buzz"); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Buzz", result1);
            Assert.AreEqual("Buzz", result2);
            Assert.AreEqual("Buzz", result3);
            Assert.AreEqual("Fizz", result4);
        }
    }
}