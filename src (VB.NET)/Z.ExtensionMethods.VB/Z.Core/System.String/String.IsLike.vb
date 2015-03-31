
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text.RegularExpressions

Public Module Extensions_505

	''' <summary>
	'''     A string extension method that query if '@this' satisfy the specified pattern.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="pattern">The pattern to use. Use '*' as wildcard string.</param>
	''' <returns>true if '@this' satisfy the specified pattern, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsLike(this As String, pattern As String) As Boolean
		' Turn the pattern into regex pattern, and match the whole string with ^$
		Dim regexPattern As String = "^" + Regex.Escape(pattern) + "$"

		' Escape special character ?, #, *, [], and [!]
		regexPattern = regexPattern.Replace("\[!", "[^").Replace("\[", "[").Replace("\]", "]").Replace("\?", ".").Replace("\*", ".*").Replace("\#", "\d")

		Return Regex.IsMatch(this, regexPattern)
	End Function
End Module


