
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text.RegularExpressions

Public Module Extensions_581

	''' <summary>
	'''     A string extension method that query if 'obj' is valid email.
	''' </summary>
	''' <param name="obj">The obj to act on.</param>
	''' <returns>true if valid email, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsValidEmail(obj As String) As Boolean
		Return Regex.IsMatch(obj, "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
	End Function
End Module


