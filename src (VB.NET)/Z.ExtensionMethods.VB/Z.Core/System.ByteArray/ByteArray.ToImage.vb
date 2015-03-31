
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing
Imports System.IO

Public Module Extensions_73

	''' <summary>
	'''     A byte[] extension method that converts the @this to an image.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an Image.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToImage(this As Byte()) As Image
		Using ms = New MemoryStream(this)
			Return Image.FromStream(ms)
		End Using
	End Function
End Module


