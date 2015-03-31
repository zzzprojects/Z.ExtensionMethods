
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web

Public Module Extensions_81

	''' <summary>
	'''     Converts an array of bytes into a URL-encoded array of bytes.
	''' </summary>
	''' <param name="bytes">The array of bytes to encode.</param>
	''' <returns>An encoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlEncodeToBytes(bytes As [Byte]()) As [Byte]()
		Return HttpUtility.UrlEncodeToBytes(bytes)
	End Function

	''' <summary>
	'''     Converts an array of bytes into a URL-encoded array of bytes, starting at the specified position in the array
	'''     and continuing for the specified number of bytes.
	''' </summary>
	''' <param name="bytes">The array of bytes to encode.</param>
	''' <param name="offset">The position in the byte array at which to begin encoding.</param>
	''' <param name="count">The number of bytes to encode.</param>
	''' <returns>An encoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlEncodeToBytes(bytes As [Byte](), offset As Int32, count As Int32) As [Byte]()
		Return HttpUtility.UrlEncodeToBytes(bytes, offset, count)
	End Function
End Module


