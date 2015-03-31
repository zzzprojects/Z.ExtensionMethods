
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_281

	''' <summary>
	'''     Converts the specified Unicode code point into a UTF-16 encoded string.
	''' </summary>
	''' <param name="utf32">A 21-bit Unicode code point.</param>
	''' <returns>
	'''     A string consisting of one  object or a surrogate pair of  objects equivalent to the code point specified by
	'''     the  parameter.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertFromUtf32(utf32 As Int32) As [String]
		Return [Char].ConvertFromUtf32(utf32)
	End Function
End Module


