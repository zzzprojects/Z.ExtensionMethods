
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_498

	''' <summary>
	'''     A string extension method that get the string after the specified string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="value">The value to search.</param>
	''' <returns>The string after the specified value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetAfter(this As String, value As String) As String
		If this.IndexOf(value) = -1 Then
			Return ""
		End If
		Return this.Substring(this.IndexOf(value) + value.Length)
	End Function
End Module


