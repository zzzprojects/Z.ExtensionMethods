
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_89

	''' <summary>
	'''     Indicates whether the specified  object is a high surrogate.
	''' </summary>
	''' <param name="c">The Unicode character to evaluate.</param>
	''' <returns>
	'''     true if the numeric value of the  parameter ranges from U+D800 through U+DBFF; otherwise, false.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsHighSurrogate(c As [Char]) As [Boolean]
		Return [Char].IsHighSurrogate(c)
	End Function
End Module


