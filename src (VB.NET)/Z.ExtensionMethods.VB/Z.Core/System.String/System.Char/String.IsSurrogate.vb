
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_555

	''' <summary>
	'''     Indicates whether the character at the specified position in a specified string has a surrogate code unit.
	''' </summary>
	''' <param name="s">A string.</param>
	''' <param name="index">The position of the character to evaluate in .</param>
	''' <returns>
	'''     true if the character at position  in  is a either a high surrogate or a low surrogate; otherwise, false.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsSurrogate(s As [String], index As Int32) As [Boolean]
		Return [Char].IsSurrogate(s, index)
	End Function
End Module


