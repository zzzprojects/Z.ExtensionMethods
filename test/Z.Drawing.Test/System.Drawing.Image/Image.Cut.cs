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