
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Web

Public Module Extensions_571

	''' <summary>
	'''     Minimally converts a string to an HTML-encoded string.
	''' </summary>
	''' <param name="s">The string to encode.</param>
	''' <returns>An encoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function HtmlAttributeEncode(s As [String]) As [String]
		Return HttpUtility.HtmlAttributeEncode(s)
	End Function

	''' <summary>
	'''     Minimally converts a string into an HTML-encoded string and sends the encoded string to a  output stream.
	''' </summary>
	''' <param name="s">The string to encode.</param>
	''' <param name="output">A  output stream.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub HtmlAttributeEncode(s As [String], output As TextWriter)
		HttpUtility.HtmlAttributeEncode(s, output)
	End Sub
End Module


