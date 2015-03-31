
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_288

	''' <summary>
	'''     Produces the full product of two 32-bit numbers.
	''' </summary>
	''' <param name="a">The first number to multiply.</param>
	''' <param name="b">The second number to multiply.</param>
	''' <returns>The number containing the product of the specified numbers.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function BigMul(a As Int32, b As Int32) As Int64
		Return Math.BigMul(a, b)
	End Function
End Module


