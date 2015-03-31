
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web

Public Module Extensions_580

	''' <summary>
	'''     Encodes the path portion of a URL string for reliable HTTP transmission from the Web server to a client.
	''' </summary>
	''' <param name="str">The text to encode.</param>
	''' <returns>The encoded text.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UrlPathEncode(str As [String]) As [String]
		Return HttpUtility.UrlPathEncode(str)
	End Function
End Module


