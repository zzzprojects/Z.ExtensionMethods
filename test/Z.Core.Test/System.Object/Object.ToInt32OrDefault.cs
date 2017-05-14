// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright ?ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_ToInt32OrDefault
    {
        [TestMethod]
        public void ToInt32OrDefault()
        {
            // Type
            string @thisValid = "32";
            string @thisInvalid = "FizzBuzz";
            string @thisNull = null;
            string @thisEmpty = "";

            // Exemples
            int result1 = @thisValid.ToInt32OrDefault(); // return 32;
            int result2 = @thisInvalid.ToInt32OrDefault(); // return 0;
            int result3 = @thisInvalid.ToInt32OrDefault(-1); // return -1;
            int result4 = @thisInvalid.ToInt32OrDefault(() => -2); // return -2;

            int result5 = @thisNull.ToInt32OrDefault(-1);
            int result6 = thisEmpty.ToInt32OrDefault(-1);

            // Unit Test
            Assert.AreEqual(32, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-1, result3);
            Assert.AreEqual(-2, result4);
        }
    }
}