
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_85

	''' <summary>
	'''     Converts the specified numeric Unicode character to a double-precision floating point number.
	''' </summary>
	''' <param name="c">The Unicode character to convert.</param>
	''' <returns>The numeric value of  if that character represents a number; otherwise, -1.0.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetNumericValue(c As [Char]) As [Double]
		Return [Char].GetNumericValue(c)
	End Function
End Module


