
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Net
Imports System.Text

Public Module Extensions_804

	''' <summary>
	'''     A WebRequest extension method that gets the WebRequest response and read the response stream.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The response stream as a string, from the current position to the end.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadToEndAndDispose(this As WebResponse) As String
		Using response As WebResponse = this
			Using stream As Stream = response.GetResponseStream()
				Using reader = New StreamReader(stream, Encoding.[Default])
					Return reader.ReadToEnd()
				End Using
			End Using
		End Using
	End Function
End Module


