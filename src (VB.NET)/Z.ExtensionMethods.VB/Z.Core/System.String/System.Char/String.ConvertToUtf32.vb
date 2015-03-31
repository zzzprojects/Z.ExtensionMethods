
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_542

	''' <summary>
	'''     Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a
	'''     Unicode code point.
	''' </summary>
	''' <param name="s">A string that contains a character or surrogate pair.</param>
	''' <param name="index">The index position of the character or surrogate pair in .</param>
	''' <returns>
	'''     The 21-bit Unicode code point represented by the character or surrogate pair at the position in the parameter
	'''     specified by the  parameter.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertToUtf32(s As [String], index As Int32) As Int32
		Return [Char].ConvertToUtf32(s, index)
	End Function
End Module


