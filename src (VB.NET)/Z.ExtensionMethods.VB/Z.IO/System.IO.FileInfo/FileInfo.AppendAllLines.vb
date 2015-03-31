
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Public Module Extensions_775

	''' <summary>
	'''     A FileInfo extension method that appends all lines.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="contents">The contents.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AppendAllLines(this As FileInfo, contents As IEnumerable(Of [String]))
		File.AppendAllLines(this.FullName, contents)
	End Sub

	''' <summary>
	'''     A FileInfo extension method that appends all lines.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="contents">The contents.</param>
	''' <param name="encoding">The encoding.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AppendAllLines(this As FileInfo, contents As IEnumerable(Of [String]), encoding As Encoding)
		File.AppendAllLines(this.FullName, contents, encoding)
	End Sub
End Module


