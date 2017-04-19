// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Drawing.Test
{
    [TestClass]
    public class System_Drawing_Image_Scale
    {
        [TestMethod]
        public void Scale()
        {
            // Type
            var @this = new Bitmap(1, 1);

            // Examples
            Image value1 = @this.Scale(2); // return an Image(2, 2);
            Image value2 = @this.Scale(2, 2); // return an Image(2, 2);

            // Unit Test
            Assert.AreEqual(2, value1.Width);
            Assert.AreEqual(2, value1.Height);
            Assert.AreEqual(2, value2.Width);
            Assert.AreEqual(2, value2.Height);
        }
    }
}