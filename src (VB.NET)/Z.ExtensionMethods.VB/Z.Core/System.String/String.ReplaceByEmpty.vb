
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_522

	''' <summary>
	'''     A string extension method that replace all values specified by an empty string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>A string with all specified values replaced by an empty string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReplaceByEmpty(this As String, ParamArray values As String()) As String
		For Each value As String In values
			this = this.Replace(value, "")
		Next

		Return this
	End Function
End Module


