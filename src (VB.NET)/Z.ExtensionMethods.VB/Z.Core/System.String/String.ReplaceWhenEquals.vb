
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_525

	''' <summary>
	'''     A string extension method that replace when equals.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="oldValue">The old value.</param>
	''' <param name="newValue">The new value.</param>
	''' <returns>The new value if the string equal old value; Otherwise old value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReplaceWhenEquals(this As String, oldValue As String, newValue As String) As String
		Return If(this = oldValue, newValue, this)
	End Function
End Module


