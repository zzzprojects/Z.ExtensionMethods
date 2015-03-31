
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_529

	''' <summary>
	'''     A string extension method that save the string into a file.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="fileName">Filename of the file.</param>
	''' <param name="append">(Optional) if the text should be appended to file file if it's exists.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SaveAs(this As String, fileName As String, Optional append As Boolean = False)
		Using tw As TextWriter = New StreamWriter(fileName, append)
			tw.Write(this)
		End Using
	End Sub

	''' <summary>
	'''     A string extension method that save the string into a file.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="file">The FileInfo.</param>
	''' <param name="append">(Optional) if the text should be appended to file file if it's exists.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SaveAs(this As String, file As FileInfo, Optional append As Boolean = False)
		Using tw As TextWriter = New StreamWriter(file.FullName, append)
			tw.Write(this)
		End Using
	End Sub
End Module


