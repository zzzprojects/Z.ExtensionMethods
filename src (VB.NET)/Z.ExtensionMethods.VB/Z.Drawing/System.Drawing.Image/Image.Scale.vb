
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Module Extensions_750

	''' <summary>
	'''     An Image extension method that scales an image to the specific ratio.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="ratio">The ratio.</param>
	''' <returns>The scaled image to the specific ratio.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Scale(this As Image, ratio As Double) As Image
		Dim width As Integer = Convert.ToInt32(this.Width * ratio)
		Dim height As Integer = Convert.ToInt32(this.Height * ratio)

		Dim r = New Bitmap(width, height)

		Using g As Graphics = Graphics.FromImage(r)
			g.CompositingQuality = CompositingQuality.HighQuality
			g.SmoothingMode = SmoothingMode.HighQuality
			g.InterpolationMode = InterpolationMode.HighQualityBicubic

			g.DrawImage(this, 0, 0, width, height)
		End Using

		Return r
	End Function

	''' <summary>
	'''     An Image extension method that scales an image to a specific with and height.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="width">The width.</param>
	''' <param name="height">The height.</param>
	''' <returns>The scaled image to the specific width and height.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Scale(this As Image, width As Integer, height As Integer) As Image
		Dim r = New Bitmap(width, height)

		Using g As Graphics = Graphics.FromImage(r)
			g.CompositingQuality = CompositingQuality.HighQuality
			g.SmoothingMode = SmoothingMode.HighQuality
			g.InterpolationMode = InterpolationMode.HighQualityBicubic

			g.DrawImage(this, 0, 0, width, height)
		End Using

		Return r
	End Function
End Module


