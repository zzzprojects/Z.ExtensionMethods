
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_93

	''' <summary>
	'''     Indicates whether the specified  object is a low surrogate.
	''' </summary>
	''' <param name="c">The character to evaluate.</param>
	''' <returns>
	'''     true if the numeric value of the  parameter ranges from U+DC00 through U+DFFF; otherwise, false.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsLowSurrogate(c As [Char]) As [Boolean]
		Return [Char].IsLowSurrogate(c)
	End Function
End Module


