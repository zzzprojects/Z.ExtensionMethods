
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_526

	''' <summary>
	'''     A string extension method that reverses the given string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The string reversed.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Reverse(this As String) As String
		If this.Length <= 1 Then
			Return this
		End If

		Dim chars As Char() = this.ToCharArray()
		Array.Reverse(chars)
		Return New String(chars)
	End Function
End Module


