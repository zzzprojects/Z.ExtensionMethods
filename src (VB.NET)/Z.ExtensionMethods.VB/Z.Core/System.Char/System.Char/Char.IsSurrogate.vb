
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_97

	''' <summary>
	'''     Indicates whether the specified character has a surrogate code unit.
	''' </summary>
	''' <param name="c">The Unicode character to evaluate.</param>
	''' <returns>true if  is either a high surrogate or a low surrogate; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsSurrogate(c As [Char]) As [Boolean]
		Return [Char].IsSurrogate(c)
	End Function
End Module


