
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text.RegularExpressions

Public Module Extensions_570

	''' <summary>
	'''     Searches the specified input string for all occurrences of a specified regular expression.
	''' </summary>
	''' <param name="input">The string to search for a match.</param>
	''' <param name="pattern">The regular expression pattern to match.</param>
	''' <returns>
	'''     A collection of the  objects found by the search. If no matches are found, the method returns an empty
	'''     collection object.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Matches(input As [String], pattern As [String]) As MatchCollection
		Return Regex.Matches(input, pattern)
	End Function

	''' <summary>
	'''     Searches the specified input string for all occurrences of a specified regular expression, using the
	'''     specified matching options.
	''' </summary>
	''' <param name="input">The string to search for a match.</param>
	''' <param name="pattern">The regular expression pattern to match.</param>
	''' <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
	''' <returns>
	'''     A collection of the  objects found by the search. If no matches are found, the method returns an empty
	'''     collection object.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Matches(input As [String], pattern As [String], options As RegexOptions) As MatchCollection
		Return Regex.Matches(input, pattern, options)
	End Function
End Module


