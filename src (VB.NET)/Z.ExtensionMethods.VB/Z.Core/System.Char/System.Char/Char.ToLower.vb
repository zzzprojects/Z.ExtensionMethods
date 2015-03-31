
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Globalization

Public Module Extensions_102

	''' <summary>
	'''     Converts the value of a specified Unicode character to its lowercase equivalent using specified culture-
	'''     specific formatting information.
	''' </summary>
	''' <param name="c">The Unicode character to convert.</param>
	''' <param name="culture">An object that supplies culture-specific casing rules.</param>
	''' <returns>
	'''     The lowercase equivalent of , modified according to , or the unchanged value of , if  is already lowercase or
	'''     not alphabetic.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToLower(c As [Char], culture As CultureInfo) As [Char]
		Return [Char].ToLower(c, culture)
	End Function

	''' <summary>
	'''     Converts the value of a Unicode character to its lowercase equivalent.
	''' </summary>
	''' <param name="c">The Unicode character to convert.</param>
	''' <returns>
	'''     The lowercase equivalent of , or the unchanged value of , if  is already lowercase or not alphabetic.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToLower(c As [Char]) As [Char]
		Return [Char].ToLower(c)
	End Function
End Module


