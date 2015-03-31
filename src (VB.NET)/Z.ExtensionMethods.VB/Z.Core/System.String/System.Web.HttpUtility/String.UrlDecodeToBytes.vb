
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text
Imports System.Web

Public Module Extensions_577

	''' <summary>
	'''     Converts a URL-encoded string into a decoded array of bytes.
	''' </summary>
	''' <param name="str">The string to decode.</param>
	''' <returns>A decoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecodeToBytes(str As [String]) As [Byte]()
		Return HttpUtility.UrlDecodeToBytes(str)
	End Function

	''' <summary>
	'''     Converts a URL-encoded string into a decoded array of bytes using the specified decoding object.
	''' </summary>
	''' <param name="str">The string to decode.</param>
	''' <param name="e">The  object that specifies the decoding scheme.</param>
	''' <returns>A decoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecodeToBytes(str As [String], e As Encoding) As [Byte]()
		Return HttpUtility.UrlDecodeToBytes(str, e)
	End Function
End Module


