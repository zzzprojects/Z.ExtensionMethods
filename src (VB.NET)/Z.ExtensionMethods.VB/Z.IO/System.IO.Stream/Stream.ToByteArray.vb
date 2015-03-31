
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_798

	''' <summary>
	'''     A Stream extension method that converts the Stream to a byte array.
	''' </summary>
	''' <param name="this">The Stream to act on.</param>
	''' <returns>The Stream as a byte[].</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToByteArray(this As Stream) As Byte()
		Using ms = New MemoryStream()
			this.CopyTo(ms)
			Return ms.ToArray()
		End Using
	End Function
End Module


