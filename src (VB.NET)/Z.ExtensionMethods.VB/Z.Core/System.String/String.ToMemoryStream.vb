
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Text

Public Module Extensions_535

	''' <summary>
	'''     A string extension method that converts the @this to a MemoryStream.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a MemoryStream.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToMemoryStream(this As String) As Stream
		Dim encoding As Encoding = Activator.CreateInstance(Of ASCIIEncoding)()
		Return New MemoryStream(encoding.GetBytes(this))
	End Function
End Module


