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