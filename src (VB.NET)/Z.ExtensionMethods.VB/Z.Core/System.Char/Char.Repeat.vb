
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_82

	''' <summary>
	'''     A char extension method that repeats a character the specified number of times.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="repeatCount">Number of repeats.</param>
	''' <returns>The repeated char.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Repeat(this As Char, repeatCount As Integer) As String
		Return New String(this, repeatCount)
	End Function
End Module


