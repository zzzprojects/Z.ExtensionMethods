
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Web

Public Module Extensions_573

	''' <summary>
	'''     Converts a string to an HTML-encoded string.
	''' </summary>
	''' <param name="s">The string to encode.</param>
	''' <returns>An encoded string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function HtmlEncode(s As [String]) As [String]
		Return HttpUtility.HtmlEncode(s)
	End Function

	''' <summary>
	'''     Converts a string into an HTML-encoded string, and returns the output as a  stream of output.
	''' </summary>
	''' <param name="s">The string to encode.</param>
	''' <param name="output">A  output stream.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub HtmlEncode(s As [String], output As TextWriter)
		HttpUtility.HtmlEncode(s, output)
	End Sub
End Module


