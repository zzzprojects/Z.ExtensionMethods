
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text.RegularExpressions

Public Module Extensions_503

	''' <summary>
	'''     A string extension method that query if '@this' is Alphanumeric.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if Alphanumeric, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsAlphaNumeric(this As String) As Boolean
		Return Not Regex.IsMatch(this, "[^a-zA-Z0-9]")
	End Function
End Module


