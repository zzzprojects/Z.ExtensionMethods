
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text

Public Module Extensions_520

	''' <summary>
	'''     A string extension method that repeats the string a specified number of times.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="repeatCount">Number of repeats.</param>
	''' <returns>The repeated string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Repeat(this As String, repeatCount As Integer) As String
		If this.Length = 1 Then
			Return New String(this(0), repeatCount)
		End If

		Dim sb = New StringBuilder(repeatCount * this.Length)
		While System.Math.Max(System.Threading.Interlocked.Decrement(repeatCount),repeatCount + 1) > 0
			sb.Append(this)
		End While

		Return sb.ToString()
	End Function
End Module


