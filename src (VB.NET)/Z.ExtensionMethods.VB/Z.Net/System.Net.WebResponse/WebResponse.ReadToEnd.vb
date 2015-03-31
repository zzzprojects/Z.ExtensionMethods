
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Net

Public Module Extensions_803

	''' <summary>
	'''     A WebResponse extension method that reads the response stream to the end.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The response stream as a string, from the current position to the end.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadToEnd(this As WebResponse) As String
		Using stream As Stream = this.GetResponseStream()
			Using reader = New StreamReader(stream)
				Return reader.ReadToEnd()
			End Using
		End Using
	End Function
End Module


