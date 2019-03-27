// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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