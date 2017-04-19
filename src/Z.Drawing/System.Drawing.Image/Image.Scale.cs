// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public static partial class Extensions
{
    /// <summary>
    ///     An Image extension method that scales an image to the specific ratio.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="ratio">The ratio.</param>
    /// <returns>The scaled image to the specific ratio.</returns>
    public static Image Scale(this Image @this, double ratio)
    {
        int width = Convert.ToInt32(@this.Width*ratio);
        int height = Convert.ToInt32(@this.Height*ratio);

        var r = new Bitmap(width, height);

        using (Graphics g = Graphics.FromImage(r))
        {
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(@this, 0, 0, width, height);
        }

        return r;
    }

    /// <summary>
    ///     An Image extension method that scales an image to a specific with and height.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    /// <returns>The scaled image to the specific width and height.</returns>
    public static Image Scale(this Image @this, int width, int height)
    {
        var r = new Bitmap(width, height);

        using (Graphics g = Graphics.FromImage(r))
        {
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(@this, 0, 0, width, height);
        }

        return r;
    }
}