
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_500

	''' <summary>
	'''     A string extension method that get the string between the two specified string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="before">The string before to search.</param>
	''' <param name="after">The string after to search.</param>
	''' <returns>The string between the two specified string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetBetween(this As String, before As String, after As String) As String
		Dim beforeStartIndex As Integer = this.IndexOf(before)
		Dim startIndex As Integer = beforeStartIndex + before.Length
		Dim afterStartIndex As Integer = this.IndexOf(after, startIndex)

		If beforeStartIndex = -1 OrElse afterStartIndex = -1 Then
			Return ""
		End If

		Return this.Substring(startIndex, afterStartIndex - startIndex)
	End Function
End Module


