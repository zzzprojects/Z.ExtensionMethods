// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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