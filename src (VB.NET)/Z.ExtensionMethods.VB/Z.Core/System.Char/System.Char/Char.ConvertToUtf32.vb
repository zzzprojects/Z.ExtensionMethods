
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_84

	''' <summary>
	'''     Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
	''' </summary>
	''' <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF).</param>
	''' <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF).</param>
	''' <returns>The 21-bit Unicode code point represented by the  and  parameters.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertToUtf32(highSurrogate As [Char], lowSurrogate As [Char]) As Int32
		Return [Char].ConvertToUtf32(highSurrogate, lowSurrogate)
	End Function
End Module


