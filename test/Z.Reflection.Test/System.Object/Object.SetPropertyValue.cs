// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class System_Object_SetPropertyValue
    {
        [TestMethod]
        public void SetPropertyValue()
        {
            // Type
            var @this = new TestClass();

            // Exemples
            @this.SetPropertyValue("PublicProperty", 1);
            @this.SetPropertyValue("InternaStaticlProperty", 2);

            // Unit Test
            Assert.AreEqual(1, @this.PublicProperty);
            Assert.AreEqual(2, TestClass.InternaStaticlProperty);
        }

        public class TestClass
        {
            internal static int InternaStaticlProperty { get; set; }
            public int PublicProperty { get; set; }
        }
    }
}