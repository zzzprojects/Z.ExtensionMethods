
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text.RegularExpressions

Public Module Extensions_568

	''' <summary>
	'''     Indicates whether the specified regular expression finds a match in the specified input string.
	''' </summary>
	''' <param name="input">The string to search for a match.</param>
	''' <param name="pattern">The regular expression pattern to match.</param>
	''' <returns>true if the regular expression finds a match; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsMatch(input As [String], pattern As [String]) As [Boolean]
		Return Regex.IsMatch(input, pattern)
	End Function

	''' <summary>
	'''     Indicates whether the specified regular expression finds a match in the specified input string, using the
	'''     specified matching options.
	''' </summary>
	''' <param name="input">The string to search for a match.</param>
	''' <param name="pattern">The regular expression pattern to match.</param>
	''' <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
	''' <returns>true if the regular expression finds a match; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsMatch(input As [String], pattern As [String], options As RegexOptions) As [Boolean]
		Return Regex.IsMatch(input, pattern, options)
	End Function
End Module


