
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web

Public Module Extensions_80

	''' <summary>
	'''     Converts a byte array into an encoded URL string.
	''' </summary>
	''' <param name="bytes">The array of bytes to encode.</param>
	''' <returns>An encoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlEncode(bytes As [Byte]()) As [String]
		Return HttpUtility.UrlEncode(bytes)
	End Function

	''' <summary>
	'''     Converts a byte array into a URL-encoded string, starting at the specified position in the array and
	'''     continuing for the specified number of bytes.
	''' </summary>
	''' <param name="bytes">The array of bytes to encode.</param>
	''' <param name="offset">The position in the byte array at which to begin encoding.</param>
	''' <param name="count">The number of bytes to encode.</param>
	''' <returns>An encoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlEncode(bytes As [Byte](), offset As Int32, count As Int32) As [String]
		Return HttpUtility.UrlEncode(bytes, offset, count)
	End Function
End Module


