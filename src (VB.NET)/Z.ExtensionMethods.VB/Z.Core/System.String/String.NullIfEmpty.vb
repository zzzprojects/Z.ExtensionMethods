
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_514

	''' <summary>
	'''     A string extension method that return null if the value is empty else the value.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>null if the value is empty, otherwise the value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function NullIfEmpty(this As String) As String
		Return If(this = "", Nothing, this)
	End Function
End Module


