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
    public class System_Drawing_Image_Cut
    {
        [TestMethod]
        public void Cut()
        {
            // Type
            var @this = new Bitmap(2, 2);

            // Examples
            Image value = @this.Cut(1, 1, 1, 1); // Return an Image(1, 1)

            // Unit Test
            Assert.AreEqual(1, value.Width);
            Assert.AreEqual(1, value.Height);
        }
    }
}