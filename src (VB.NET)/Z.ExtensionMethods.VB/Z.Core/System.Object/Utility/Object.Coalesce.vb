
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_446

	''' <summary>
	'''     A T extension method that that return the first not null value (including the @this).
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>The first not null value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Coalesce(Of T As Class)(this As T, ParamArray values As T()) As T
		If this IsNot Nothing Then
			Return this
		End If

		For Each value As T In values
			If value IsNot Nothing Then
				Return value
			End If
		Next

		Return Nothing
	End Function
End Module


