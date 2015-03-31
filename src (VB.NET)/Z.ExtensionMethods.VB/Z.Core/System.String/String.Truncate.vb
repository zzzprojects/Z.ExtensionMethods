
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_541

	''' <summary>
	'''     A string extension method that truncates.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="maxLength">The maximum length.</param>
	''' <returns>A string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Truncate(this As String, maxLength As Integer) As String
		Const  suffix As String = "..."

		If this Is Nothing OrElse this.Length <= maxLength Then
			Return this
		End If

		Dim strLength As Integer = maxLength - suffix.Length
		Return this.Substring(0, strLength) & suffix
	End Function

	''' <summary>
	'''     A string extension method that truncates.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="maxLength">The maximum length.</param>
	''' <param name="suffix">The suffix.</param>
	''' <returns>A string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Truncate(this As String, maxLength As Integer, suffix As String) As String
		If this Is Nothing OrElse this.Length <= maxLength Then
			Return this
		End If

		Dim strLength As Integer = maxLength - suffix.Length
		Return this.Substring(0, strLength) & suffix
	End Function
End Module


