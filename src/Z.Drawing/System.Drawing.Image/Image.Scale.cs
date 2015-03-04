// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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