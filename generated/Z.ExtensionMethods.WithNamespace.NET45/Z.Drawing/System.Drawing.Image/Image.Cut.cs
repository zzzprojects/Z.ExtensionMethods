using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.DrawingExtensions
{

using System.Drawing;

public static partial class Extensions
{
    /// <summary>
    ///     An Image extension method that cuts an image.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    /// <returns>The cutted image.</returns>
    public static Image Cut(this Image @this, int width, int height, int x, int y)
    {
        var r = new Bitmap(width, height);
        var destinationRectange = new Rectangle(0, 0, width, height);
        var sourceRectangle = new Rectangle(x, y, width, height);

        using (Graphics g = Graphics.FromImage(r))
        {
            g.DrawImage(@this, destinationRectange, sourceRectangle, GraphicsUnit.Pixel);
        }

        return r;
    }
}

}