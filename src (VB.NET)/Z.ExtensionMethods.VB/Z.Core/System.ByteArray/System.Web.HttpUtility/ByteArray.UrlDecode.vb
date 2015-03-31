
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text
Imports System.Web

Public Module Extensions_78

	''' <summary>
	'''     Converts a URL-encoded byte array into a decoded string using the specified decoding object.
	''' </summary>
	''' <param name="bytes">The array of bytes to decode.</param>
	''' <param name="e">The  that specifies the decoding scheme.</param>
	''' <returns>A decoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecode(bytes As [Byte](), e As Encoding) As [String]
		Return HttpUtility.UrlDecode(bytes, e)
	End Function

	''' <summary>
	'''     Converts a URL-encoded byte array into a decoded string using the specified encoding object, starting at the
	'''     specified position in the array, and continuing for the specified number of bytes.
	''' </summary>
	''' <param name="bytes">The array of bytes to decode.</param>
	''' <param name="offset">The position in the byte to begin decoding.</param>
	''' <param name="count">The number of bytes to decode.</param>
	''' <param name="e">The  object that specifies the decoding scheme.</param>
	''' <returns>A decoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecode(bytes As [Byte](), offset As Int32, count As Int32, e As Encoding) As [String]
		Return HttpUtility.UrlDecode(bytes, offset, count, e)
	End Function
End Module


