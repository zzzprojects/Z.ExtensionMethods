
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_543

	''' <summary>
	'''     Converts the numeric Unicode character at the specified position in a specified string to a double-precision
	'''     floating point number.
	''' </summary>
	''' <param name="s">A .</param>
	''' <param name="index">The character position in .</param>
	''' <returns>
	'''     The numeric value of the character at position  in  if that character represents a number; otherwise, -1.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetNumericValue(s As [String], index As Int32) As [Double]
		Return [Char].GetNumericValue(s, index)
	End Function
End Module


