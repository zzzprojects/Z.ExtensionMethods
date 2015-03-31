
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_547

	''' <summary>
	'''     Indicates whether the  object at the specified position in a string is a high surrogate.
	''' </summary>
	''' <param name="s">A string.</param>
	''' <param name="index">The position of the character to evaluate in .</param>
	''' <returns>
	'''     true if the numeric value of the specified character in the  parameter ranges from U+D800 through U+DBFF;
	'''     otherwise, false.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsHighSurrogate(s As [String], index As Int32) As [Boolean]
		Return [Char].IsHighSurrogate(s, index)
	End Function
End Module


