
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing

Public Module Extensions_749

	''' <summary>
	'''     An Image extension method that cuts an image.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="width">The width.</param>
	''' <param name="height">The height.</param>
	''' <param name="x">The x coordinate.</param>
	''' <param name="y">The y coordinate.</param>
	''' <returns>The cutted image.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Cut(this As Image, width As Integer, height As Integer, x As Integer, y As Integer) As Image
		Dim r = New Bitmap(width, height)
		Dim destinationRectange = New Rectangle(0, 0, width, height)
		Dim sourceRectangle = New Rectangle(x, y, width, height)

		Using g As Graphics = Graphics.FromImage(r)
			g.DrawImage(this, destinationRectange, sourceRectangle, GraphicsUnit.Pixel)
		End Using

		Return r
	End Function
End Module


