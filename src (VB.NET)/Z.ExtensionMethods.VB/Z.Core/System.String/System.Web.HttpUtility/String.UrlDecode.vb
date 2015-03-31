
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text
Imports System.Web

Public Module Extensions_576

	''' <summary>
	'''     Converts a string that has been encoded for transmission in a URL into a decoded string.
	''' </summary>
	''' <param name="str">The string to decode.</param>
	''' <returns>A decoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecode(str As [String]) As [String]
		Return HttpUtility.UrlDecode(str)
	End Function

	''' <summary>
	'''     Converts a URL-encoded string into a decoded string, using the specified encoding object.
	''' </summary>
	''' <param name="str">The string to decode.</param>
	''' <param name="e">The  that specifies the decoding scheme.</param>
	''' <returns>A decoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlDecode(str As [String], e As Encoding) As [String]
		Return HttpUtility.UrlDecode(str, e)
	End Function
End Module


