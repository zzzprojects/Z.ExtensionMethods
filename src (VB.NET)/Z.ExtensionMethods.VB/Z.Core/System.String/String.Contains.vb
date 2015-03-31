
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_486

	''' <summary>
	'''     A string extension method that query if this object contains the given value.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="value">The value.</param>
	''' <returns>true if the value is in the string, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Contains(this As String, value As String) As Boolean
		Return this.IndexOf(value) <> -1
	End Function

	''' <summary>
	'''     A string extension method that query if this object contains the given value.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="value">The value.</param>
	''' <param name="comparisonType">Type of the comparison.</param>
	''' <returns>true if the value is in the string, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Contains(this As String, value As String, comparisonType As StringComparison) As Boolean
		Return this.IndexOf(value, comparisonType) <> -1
	End Function
End Module


