
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Web

Public Module Extensions_572

	''' <summary>
	'''     Converts a string that has been HTML-encoded for HTTP transmission into a decoded string.
	''' </summary>
	''' <param name="s">The string to decode.</param>
	''' <returns>A decoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function HtmlDecode(s As [String]) As [String]
		Return HttpUtility.HtmlDecode(s)
	End Function

	''' <summary>
	'''     Converts a string that has been HTML-encoded into a decoded string, and sends the decoded string to a  output
	'''     stream.
	''' </summary>
	''' <param name="s">The string to decode.</param>
	''' <param name="output">A  stream of output.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub HtmlDecode(s As [String], output As TextWriter)
		HttpUtility.HtmlDecode(s, output)
	End Sub
End Module


