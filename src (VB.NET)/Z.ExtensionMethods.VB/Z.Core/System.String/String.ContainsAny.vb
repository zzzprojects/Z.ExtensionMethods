
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_488

	''' <summary>
	'''     A string extension method that query if '@this' contains any values.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>true if it contains any values, otherwise false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ContainsAny(this As String, ParamArray values As String()) As Boolean
		For Each value As String In values
			If this.IndexOf(value) <> -1 Then
				Return True
			End If
		Next
		Return False
	End Function

	''' <summary>
	'''     A string extension method that query if '@this' contains any values.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="comparisonType">Type of the comparison.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>true if it contains any values, otherwise false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ContainsAny(this As String, comparisonType As StringComparison, ParamArray values As String()) As Boolean
		For Each value As String In values
			If this.IndexOf(value, comparisonType) <> -1 Then
				Return True
			End If
		Next
		Return False
	End Function
End Module


