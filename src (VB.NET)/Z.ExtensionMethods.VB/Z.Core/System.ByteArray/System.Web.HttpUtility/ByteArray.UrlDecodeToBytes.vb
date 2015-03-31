
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web

Public Module Extensions_79

	''' <summary>
	'''     Converts a URL-encoded array of bytes into a decoded array of bytes.
	''' </summary>
	''' <param name="bytes">The array of bytes to decode.</param>
	''' <returns>A decoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecodeToBytes(bytes As [Byte]()) As [Byte]()
		Return HttpUtility.UrlDecodeToBytes(bytes)
	End Function

	''' <summary>
	'''     Converts a URL-encoded array of bytes into a decoded array of bytes, starting at the specified position in
	'''     the array and continuing for the specified number of bytes.
	''' </summary>
	''' <param name="bytes">The array of bytes to decode.</param>
	''' <param name="offset">The position in the byte array at which to begin decoding.</param>
	''' <param name="count">The number of bytes to decode.</param>
	''' <returns>A decoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecodeToBytes(bytes As [Byte](), offset As Int32, count As Int32) As [Byte]()
		Return HttpUtility.UrlDecodeToBytes(bytes, offset, count)
	End Function
End Module


