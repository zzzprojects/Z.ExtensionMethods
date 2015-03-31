
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text
Imports System.Web

Public Module Extensions_579

	''' <summary>
	'''     Converts a string into a URL-encoded array of bytes.
	''' </summary>
	''' <param name="str">The string to encode.</param>
	''' <returns>An encoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlEncodeToBytes(str As [String]) As [Byte]()
		Return HttpUtility.UrlEncodeToBytes(str)
	End Function

	''' <summary>
	'''     Converts a string into a URL-encoded array of bytes using the specified encoding object.
	''' </summary>
	''' <param name="str">The string to encode.</param>
	''' <param name="e">The  that specifies the encoding scheme.</param>
	''' <returns>An encoded array of bytes.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlEncodeToBytes(str As [String], e As Encoding) As [Byte]()
		Return HttpUtility.UrlEncodeToBytes(str, e)
	End Function
End Module


